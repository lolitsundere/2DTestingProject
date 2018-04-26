using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class WorldManager : MonoBehaviour {

    public List<GameObject> FloorList;
    public List<GameObject> OuterWallList;
    public List<GameObject> InnerWallList;
    public GameObject ExitDown;
    public GameObject ExitUp;
    public GameObject ExitLeft;
    public GameObject ExitRight;
    public GameObject NormalEnemy;
    public GameObject Wall3D;
    public GameObject NormalEnemy3D;
    public List<GameObject> BasicTowerList;
    public Text InfoMessage;
    public Text MazeLengthMessage;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Text ItemInfo1;
    public Text ItemInfo2;
    public Text ItemInfo3;
    public Text ItemInfo4;


    private const int WorldWidth = 39;
    private const int WorldHeight = 39;
    private int Level = 1;

    private readonly Vector2 Enter = new Vector2(5f, 33f);
    private readonly Vector2 Exit = new Vector2(33f, 5f);
    private readonly Vector2 TurningPoint1 = new Vector2(5f, 19f);
    private readonly Vector2 TurningPoint2 = new Vector2(33f, 19f);
    private readonly Vector2 TurningPoint3 = new Vector2(33f, 33f);
    private readonly Vector2 TurningPoint4 = new Vector2(19f, 33f);
    private readonly Vector2 TurningPoint5 = new Vector2(19f, 5f);

    private GameObject SelectedObject;

    private const int EnemyPerLevel = 10;
    private int CurrentEnemyAcount = 0;

    private const int TowerPerTurn = 5;
    private List<GameObject> OneTurnTowerList = new List<GameObject>();

    private enum Phase{ConstructingTower,SecetingTower,EnemySpawning};
    private Phase CurrentPhase;

    private System.Random random = new System.Random();

    private Dictionary<GameObject, GameObject> EnemyDic = new Dictionary<GameObject, GameObject>();
    private Dictionary<GameObject, GameObject> InnerWallDic = new Dictionary<GameObject, GameObject>();


    private List<List<GameObject>> FloorMap = new List<List<GameObject>>();
    private int[,] IntMap = new int[WorldWidth,WorldHeight];

    public HashSet<NavMeshSurface> NavSet = new HashSet<NavMeshSurface>();

    private SpriteRenderer EnabledAttackRange;


    void Start()
    {
        CurrentPhase=Phase.ConstructingTower;
        CreateWorld();
        MazeLengthMessage.text = "迷宫长度:" + GetMazeLength();
    }


    private void FixedUpdate()
    {
        List<GameObject> deadEnemy = new List<GameObject>();
        foreach (GameObject enemy in EnemyDic.Keys)
        {
            if (enemy.GetComponent<EnemyController>().Health > 0)
            {
                enemy.transform.position = new Vector3(EnemyDic[enemy].transform.position.x, EnemyDic[enemy].transform.position.z, -1f);
            }
            else
            {
                deadEnemy.Add(enemy);
            }
        }

        for (int i = 0; i<deadEnemy.Count; i++)
        {
            DestroyEnemy(deadEnemy[i]);
            if (deadEnemy[i]==SelectedObject)
            {
                SelectedObject = null;
                ClearUI();
            }
        }
    }

    private void Update()
    {
        if (SelectedObject != null && SelectedObject.tag == "Tower")
        {
            ItemInfo1.text = TowerManager.GetTowerName(TowerManager.GetTowerType(SelectedObject));
            ItemInfo2.text = String.Format("攻击力:{0}", SelectedObject.GetComponent<TowerController>().PhysicalDamage);
            ItemInfo3.text = String.Format("基础攻击间隔:{0}s", SelectedObject.GetComponent<TowerController>().BasicAttackTime);
            ItemInfo4.text = String.Format("攻击速度:{0}", SelectedObject.GetComponent<TowerController>().AttackSpeed);
        }
        switch (CurrentPhase)
        {
            case (Phase.ConstructingTower):
                if (OneTurnTowerList.Count >= TowerPerTurn)
                {
                    InfoMessage.text = "选择一个要留下的防御塔";
                    CurrentPhase = Phase.SecetingTower;
                }
                break;
            case (Phase.SecetingTower):
                break;
            case (Phase.EnemySpawning):
                if (CurrentEnemyAcount < EnemyPerLevel && EnemyDic.Count < 0)
                {
                    SpawnEnemy();
                }
                if (SelectedObject!=null && SelectedObject.tag == "Enemy")
                {
                    ItemInfo1.text = String.Format("生命值:{0}/{1}", SelectedObject.GetComponent<EnemyController>().Health, SelectedObject.GetComponent<EnemyController>().MaxHealth);
                    ItemInfo2.text = String.Format("护甲:{0}", SelectedObject.GetComponent<EnemyController>().Armor);
                    ItemInfo3.text = String.Format("魔法抗性:{0}%", SelectedObject.GetComponent<EnemyController>().MagicResistance * 100);
                    ItemInfo4.text = String.Format("移动速度:{0}", SelectedObject.GetComponent<EnemyController>().MovementSpeed);
                }
                if (CurrentEnemyAcount == EnemyPerLevel && EnemyDic.Count == 0)
                {
                    CurrentPhase = Phase.ConstructingTower;
                    InfoMessage.text = "点击地板创建5个随机防御塔";
                    CurrentEnemyAcount = 0;

                    foreach (int x in Enumerable.Range(0, WorldWidth))
                    {
                        foreach (int y in Enumerable.Range(0, WorldHeight))
                        {
                            if (IntMap[x, y] == 0)
                            {
                                FloorMap[x][y].transform.GetComponent<BoxCollider2D>().enabled = true;
                            }
                        }
                    }
                    Level++;
                }
                break;
        }
    }


    /// <summary>
    /// 重新生成寻路
    /// </summary>
    private void UpdateNavMesh()
    {
        foreach (NavMeshSurface nms in NavSet)
        {
            nms.BuildNavMesh();
        }
    }

    /// <summary>
    /// 生成初始地图
    /// </summary>
    private void CreateWorld()
    {
        NavSet.Add(GameObject.Find("Plane").transform.GetComponent<NavMeshSurface>());
        NavSet.Add(GameObject.Find("LeftWall").transform.GetComponent<NavMeshSurface>());
        NavSet.Add(GameObject.Find("RightWall").transform.GetComponent<NavMeshSurface>());
        NavSet.Add(GameObject.Find("TopWall").transform.GetComponent<NavMeshSurface>());
        NavSet.Add(GameObject.Find("BottomWall").transform.GetComponent<NavMeshSurface>());

        foreach (int posX in Enumerable.Range(0, WorldWidth))
        {
            FloorMap.Add(new List<GameObject>());
            foreach (int posY in Enumerable.Range(0, WorldHeight))
            {
                GameObject addedObject = null;

                //外墙
                if (posX == 0 || posY == 0 || posX == WorldWidth - 1 || posY == WorldHeight - 1)
                {
                    addedObject = CreateOuterWall(new Vector3(posX, posY, -1f));
                    IntMap[posX, posY] = -1;
                }
                //入口
                else if (posX == Enter.x && posY == Enter.y)
                {
                    addedObject = Instantiate(ExitDown, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<BoxCollider2D>().size = new Vector2(2.5f, 2.5f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyExitEvent += (go) =>
                    {
                        if (CurrentEnemyAcount < EnemyPerLevel)
                        {
                            SpawnEnemy();
                        }
                    };
                }
                //出口
                else if (posX == Exit.x && posY == Exit.y)
                {
                    addedObject = Instantiate(ExitRight, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            DestroyEnemy(go);
                        }
                    };
                }
                //第一个拐点
                else if (posX == TurningPoint1.x && posY == TurningPoint1.y)
                {
                    addedObject = Instantiate(ExitRight, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            nav.SetDestination(new Vector3(TurningPoint2.x, 0.275f, TurningPoint2.y));
                        }
                    };
                }
                //第二个拐点
                else if (posX == TurningPoint2.x && posY == TurningPoint2.y)
                {
                    addedObject = Instantiate(ExitUp, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            nav.SetDestination(new Vector3(TurningPoint3.x, 0.275f, TurningPoint3.y));
                        }
                    };
                }
                //第三个拐点
                else if (posX == TurningPoint3.x && posY == TurningPoint3.y)
                {
                    addedObject = Instantiate(ExitLeft, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            nav.SetDestination(new Vector3(TurningPoint4.x, 0.275f, TurningPoint4.y));
                        }
                    };
                }
                //第四个拐点
                else if (posX == TurningPoint4.x && posY == TurningPoint4.y)
                {
                    addedObject = Instantiate(ExitDown, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            nav.SetDestination(new Vector3(TurningPoint5.x, 0.275f, TurningPoint5.y));
                        }
                    };
                }
                //第五个拐点
                else if (posX == TurningPoint5.x && posY == TurningPoint5.y)
                {
                    addedObject = Instantiate(ExitRight, transform.GetChild(1).GetChild(0).transform);
                    addedObject.transform.position = new Vector3(posX, posY, -1f);
                    addedObject.GetComponent<ColliderEventHandler>().EnemyEnterEvent += (go) =>
                    {
                        var nav = EnemyDic[go].transform.GetComponent<NavMeshAgent>();
                        if (nav.destination.x == posX && nav.destination.z == posY)
                        {
                            nav.SetDestination(new Vector3(Exit.x, 0.275f, Exit.y));
                        }
                    };
                }
                //地板
                else
                {
                    addedObject = CreateFloor(new Vector3(posX, posY, -1f));
                }
                FloorMap[posX].Add(addedObject);
      
            }
        }
        CreateStartInnerWall();
    }

    /// <summary>
    /// 消灭敌人
    /// </summary>
    /// <param name="go"></param>
    private void DestroyEnemy(GameObject go)
    {
        Destroy(EnemyDic[go]);
        EnemyDic.Remove(go);
        Destroy(go);
    }

    /// <summary>
    /// 在出生点生成敌人
    /// </summary>
    private void SpawnEnemy()
    {
        var enemy = Instantiate(NormalEnemy, transform.GetChild(1).GetChild(4).transform);
        enemy.transform.position = new Vector3(Enter.x, Enter.y, -1f);
        enemy.GetComponent<ClickEventHandler>().ClickEvent += EnemyClickAction;

        var enemy3D = Instantiate(NormalEnemy3D, transform.GetChild(0).GetChild(1).transform);
        enemy3D.transform.position = new Vector3(Enter.x, 0.275f, Enter.y);
        var enemyNav = enemy3D.transform.GetComponent<NavMeshAgent>();
        enemyNav.Warp(new Vector3(Enter.x, 0.275f, Enter.y));
        enemyNav.SetDestination(new Vector3(TurningPoint1.x, 0.275f, TurningPoint1.y));

        enemy.GetComponent<EnemyController>().nav = enemyNav;
        EnemyManager.SetEnemy(enemy.GetComponent<EnemyController>(), Level);

        CurrentEnemyAcount++;
        EnemyDic.Add(enemy, enemy3D);
    }

    /// <summary>
    /// 在鼠标点击敌人时触发
    /// </summary>
    /// <param name="obj"></param>
    private void EnemyClickAction(GameObject obj)
    {
        SelectedObject = obj;
        if (EnabledAttackRange != null)
        {
            EnabledAttackRange.enabled = false;
        }
        ClearUI();
        ItemInfo1.text = String.Format("生命值:{0}/{1}", SelectedObject.GetComponent<EnemyController>().Health, SelectedObject.GetComponent<EnemyController>().MaxHealth);
        ItemInfo2.text = String.Format("护甲:{0}", SelectedObject.GetComponent<EnemyController>().Armor);
        ItemInfo3.text = String.Format("魔法抗性:{0}%", SelectedObject.GetComponent<EnemyController>().MagicResistance*100);
        ItemInfo4.text = String.Format("移动速度:{0}", SelectedObject.GetComponent<EnemyController>().MovementSpeed);
    }

    /// <summary>
    /// 创建一个随机图案的外墙
    /// </summary>
    /// <param name="pos"> 外墙的坐标</param>
    /// <returns></returns>
    private GameObject CreateOuterWall(Vector3 pos)
    {
        var outerWall = Instantiate(OuterWallList[random.Next(OuterWallList.Count)], transform.GetChild(1).GetChild(2).transform);
        outerWall.transform.position = pos;
        return outerWall;
    }

    /// <summary>
    /// 创建一个随机图案的内墙
    /// </summary>
    /// <param name="pos"> 外墙的坐标</param>
    /// <returns></returns>
    private GameObject CreateInnerWall(Vector3 pos)
    {
        var innerWall = Instantiate(InnerWallList[random.Next(InnerWallList.Count)], transform.GetChild(1).GetChild(1).transform);
        innerWall.transform.position = pos;

        var innerWall3D = Instantiate(Wall3D, transform.GetChild(0).GetChild(0).transform);
        innerWall3D.transform.position = new Vector3(pos.x, 0.4f, pos.y);
        NavSet.Add(innerWall3D.GetComponent<NavMeshSurface>());

        innerWall.GetComponent<ClickEventHandler>().ClickEvent += InnerWallClickedAction;
        FloorMap[Convert.ToInt32(pos.x)][Convert.ToInt32(pos.y)].transform.GetComponent<BoxCollider2D>().enabled = false;

        InnerWallDic.Add(innerWall, innerWall3D);
        IntMap[Convert.ToInt32(pos.x), Convert.ToInt32(pos.y)] = -1;

        return innerWall;
    }

    /// <summary>
    /// 在鼠标点击内墙时触发
    /// </summary>
    private void InnerWallClickedAction(GameObject _SelectedObject)
    {
        ClearUI();
        if (EnabledAttackRange != null)
        {
            EnabledAttackRange.enabled = false;
            EnabledAttackRange = null;
        }
        SelectedObject = _SelectedObject;
        switch (CurrentPhase)
        {
            case Phase.EnemySpawning:
                break;
            default:
                Button1.image.color = Color.white;
                Button1.GetComponentInChildren<Text>().text = "移除";
                Button1.onClick = new Button.ButtonClickedEvent();
                Button1.onClick.AddListener(RemoveSelectedInnerWall);
                break;
        }
    }

    /// <summary>
    /// 移除被选中的内墙
    /// </summary>
    private void RemoveSelectedInnerWall()
    {
        if (SelectedObject != null && SelectedObject.tag=="InnerWall")
        {
            NavSet.Remove(InnerWallDic[SelectedObject].GetComponent<NavMeshSurface>());
            FloorMap[Convert.ToInt32(SelectedObject.transform.position.x)][Convert.ToInt32(SelectedObject.transform.position.y)].transform.GetComponent<BoxCollider2D>().enabled = true;
            Destroy(InnerWallDic[SelectedObject]);
            InnerWallDic.Remove(SelectedObject);
            IntMap[Convert.ToInt32(SelectedObject.transform.position.x), Convert.ToInt32(SelectedObject.transform.position.y)] = 0;
            Destroy(SelectedObject);
            ClearUI();

            int length = GetMazeLength();
            MazeLengthMessage.text = "迷宫长度:" + length;
            MazeLengthMessage.color = Color.white;
        }
    }

    /// <summary>
    /// 创建游戏开始时在固定位置生成的内墙
    /// </summary>
    private void CreateStartInnerWall()
    {
        foreach (int i in new int[]{1,2,3,4,6,7,8,9,37,36,35,34,32,31,30,29})
        {
            CreateInnerWall(new Vector3(i, 19f, -1f));
            CreateInnerWall(new Vector3(19f, i, -1f));
        }
    }
 
    /// <summary>
    /// 创建随机防御塔
    /// </summary>
    private void CreateRandomTower(Vector3 pos)
    {
        IntMap[Convert.ToInt32(pos.x), Convert.ToInt32(pos.y)] = -1;
        int length = GetMazeLength();
        if (length == -1)
        {
            IntMap[Convert.ToInt32(pos.x), Convert.ToInt32(pos.y)] = 0;
            MazeLengthMessage.text = "不能堵死路口";
            MazeLengthMessage.color = Color.red;
            return;
        }

        MazeLengthMessage.text = "迷宫长度:" + length;
        MazeLengthMessage.color = Color.white;

        var tower = Instantiate(BasicTowerList[random.Next(3)], transform.GetChild(1).GetChild(5).transform);
        tower.transform.position = pos;
        tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        OneTurnTowerList.Add(tower);

        TowerManager.SettingTower(tower.GetComponent<TowerController>(), TowerManager.GetTowerType(tower));

        tower.GetComponent<ClickEventHandler>().ClickEvent += TowerClickedAction;

        FloorMap[Convert.ToInt32(pos.x)][Convert.ToInt32(pos.y)].transform.GetComponent<BoxCollider2D>().enabled = false;
    }

    /// <summary>
    /// 在鼠标点击防御塔时触发
    /// </summary>
    /// <param name="_SelectedObject"></param>
    private void TowerClickedAction(GameObject _SelectedObject)
    {
        SelectedObject = _SelectedObject;
        if (EnabledAttackRange != null)
        {
            EnabledAttackRange.enabled = false;
        }
        EnabledAttackRange = SelectedObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        EnabledAttackRange.enabled = true;

        ClearUI();
        ItemInfo1.text = TowerManager.GetTowerName(TowerManager.GetTowerType(SelectedObject));
        ItemInfo2.text = String.Format("攻击力:{0}", SelectedObject.GetComponent<TowerController>().PhysicalDamage);
        ItemInfo3.text = String.Format("基础攻击间隔:{0}s", SelectedObject.GetComponent<TowerController>().BasicAttackTime);
        ItemInfo4.text = String.Format("攻击速度:{0}", SelectedObject.GetComponent<TowerController>().AttackSpeed);

        switch (CurrentPhase)
        {
            case Phase.SecetingTower:
                var updateTowers = TowerCombiningManager.GetCombinableTowers(OneTurnTowerList,true);
                if (OneTurnTowerList.Contains(SelectedObject))
                { 
                    Button1.image.color = Color.white;
                    Button1.GetComponentInChildren<Text>().text = "保留这个";
                    Button1.onClick = new Button.ButtonClickedEvent();
                    Button1.onClick.AddListener(RemainSelectedTower);

                    if (updateTowers.ContainsKey(SelectedObject))
                    {
                        foreach (TowerManager.TowerType tt in updateTowers[SelectedObject])
                        {
                            if (TowerCombiningManager.CanUpgrade(SelectedObject,tt))
                            {
                                Button2.image.color = Color.white;
                                Button2.GetComponentInChildren<Text>().text = "升级";
                                Button2.onClick = new Button.ButtonClickedEvent();
                                Button2.onClick.AddListener(UpgradeSelectedTower);
                            }
                            else if (TowerCombiningManager.CanSuperUpgrade(SelectedObject, tt))
                            {
                                Button3.image.color = Color.white;
                                Button3.GetComponentInChildren<Text>().text = "超级升级";
                                Button3.onClick = new Button.ButtonClickedEvent();
                                Button3.onClick.AddListener(SuperUpgradeSelectedTower);
                            }
                        }
                    }
                }
                else
                {
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 保留被选中的防御塔，将其他防御塔变为内墙
    /// </summary>
    private void RemainSelectedTower()
    {
        if (SelectedObject != null && SelectedObject.tag == "Tower")
        {

            OneTurnTowerList.Remove(SelectedObject);
            var innerWall3D = Instantiate(Wall3D, transform.GetChild(0).GetChild(0).transform);
            innerWall3D.transform.position = new Vector3(SelectedObject.transform.position.x, 0.4f, SelectedObject.transform.position.y);
            NavSet.Add(innerWall3D.GetComponent<NavMeshSurface>());

            foreach (GameObject t in OneTurnTowerList)
            {
                CreateInnerWall(t.transform.position);
                Destroy(t);
            }

            OneTurnTowerList = new List<GameObject>();
            ClearUI();
            ItemInfo1.text = TowerManager.GetTowerName(TowerManager.GetTowerType(SelectedObject));
            ItemInfo2.text = String.Format("攻击力:{0}", SelectedObject.GetComponent<TowerController>().PhysicalDamage);
            ItemInfo3.text = String.Format("基础攻击间隔:{0}s", SelectedObject.GetComponent<TowerController>().BasicAttackTime);
            ItemInfo4.text = String.Format("攻击速度:{0}", SelectedObject.GetComponent<TowerController>().AttackSpeed);


            CurrentPhase = Phase.EnemySpawning;
            UpdateNavMesh();
            SpawnEnemy();
            InfoMessage.text = "消灭敌人";
            foreach (int x in Enumerable.Range(0,WorldWidth))
            {
                foreach (int y in Enumerable.Range(0,WorldHeight))
                {
                    FloorMap[x][y].transform.GetComponent<BoxCollider2D>().enabled = false;                    
                }
            }
            FloorMap[5][33].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[33][5].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[5][19].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[33][19].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[33][33].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[19][33].transform.GetComponent<BoxCollider2D>().enabled = true;
            FloorMap[19][5].transform.GetComponent<BoxCollider2D>().enabled = true;



        }
    }

    /// <summary>
    /// 升级被选中的防御塔，将其他防御塔变为内墙
    /// </summary>
    private void UpgradeSelectedTower()
    {
        if (SelectedObject != null && SelectedObject.tag == "Tower")
        {
            SelectedObject.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
            TowerManager.SettingTower(SelectedObject.GetComponent<TowerController>(), TowerManager.GetTowerType(SelectedObject));
            RemainSelectedTower();
        }
    }

    /// <summary>
    /// 超级升级被选中的防御塔，将其他防御塔变为内墙
    /// </summary>
    private void SuperUpgradeSelectedTower()
    {
        if (SelectedObject != null && SelectedObject.tag == "Tower")
        {
            SelectedObject.transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
            TowerManager.SettingTower(SelectedObject.GetComponent<TowerController>(), TowerManager.GetTowerType(SelectedObject));
            RemainSelectedTower();
        }
    }


    /// <summary>
    /// 重置UI状态
    /// </summary>
    private void ClearUI()
    {
        Button1.image.color = new Color(0f,0f,0f,0f);
        Button1.onClick = new Button.ButtonClickedEvent();
        Button1.GetComponentInChildren<Text>().text = "";

        Button2.image.color = new Color(0f, 0f, 0f, 0f);
        Button2.onClick = new Button.ButtonClickedEvent();
        Button2.GetComponentInChildren<Text>().text = "";

        Button3.image.color = new Color(0f, 0f, 0f, 0f);
        Button3.onClick = new Button.ButtonClickedEvent();
        Button3.GetComponentInChildren<Text>().text = "";

        Button4.image.color = new Color(0f, 0f, 0f, 0f);
        Button4.onClick = new Button.ButtonClickedEvent();
        Button4.GetComponentInChildren<Text>().text = "";

        ItemInfo1.text = "";
        ItemInfo2.text = "";
        ItemInfo3.text = "";
        ItemInfo4.text = "";

    }

    /// <summary>
    /// 创建一个随机图案的地板
    /// </summary>
    /// <param name="pos">地板的坐标</param>
    /// <returns></returns>
    private GameObject CreateFloor(Vector3 pos)
    {
        var floor = Instantiate(FloorList[random.Next(FloorList.Count)], transform.GetChild(1).GetChild(3).transform);
        floor.transform.position = pos;

        floor.GetComponent<ClickEventHandler>().ClickEvent += FloorClickedAction;
        return floor;
    }

    /// <summary>
    /// 在鼠标点击地板时触发
    /// </summary>
    /// <param name="_SelectedObject"></param>
    private void FloorClickedAction(GameObject _SelectedObject)
    {
        if (EnabledAttackRange != null)
        {
            EnabledAttackRange.enabled = false;
            EnabledAttackRange = null;
        }
        SelectedObject = _SelectedObject;
        switch (CurrentPhase)
        {
            case Phase.ConstructingTower:
                CreateRandomTower(SelectedObject.transform.position);
                break;
            default:
                ClearUI();
                break;
        }
    }

    /// <summary>
    /// 得到敌人从起点到终点需要走的距离
    /// </summary>
    /// <returns></returns>
    private int GetMazeLength()
    {
        while (true)
        {
            var copy = IntMap.Clone() as int[,];
            Point startPoint = new Point(Convert.ToInt32(Enter.x), Convert.ToInt32(Enter.y));
            Point endPoint = new Point(Convert.ToInt32(TurningPoint1.x), Convert.ToInt32(TurningPoint1.y));
            copy[startPoint.x,startPoint.y] = 1;
            List<Point> newList = new List<Point>();
            newList.Add(startPoint);
            int path1 = GetMazeLength(copy,newList,endPoint,1);
            if (path1 == -1)
            {
                return -1;
            }

            copy = IntMap.Clone() as int[,];
            startPoint = endPoint;
            endPoint = new Point(Convert.ToInt32(TurningPoint2.x), Convert.ToInt32(TurningPoint2.y));
            copy[startPoint.x, startPoint.y] = 1;
            newList = new List<Point>();
            newList.Add(startPoint);
            int path2 = GetMazeLength(copy, newList, endPoint, 1);
            if (path2 == -1)
            {
                return -1;
            }

            copy = IntMap.Clone() as int[,];
            startPoint = endPoint;
            endPoint = new Point(Convert.ToInt32(TurningPoint3.x), Convert.ToInt32(TurningPoint3.y));
            copy[startPoint.x, startPoint.y] = 1;
            newList = new List<Point>();
            newList.Add(startPoint);
            int path3 = GetMazeLength(copy, newList, endPoint, 1);
            if (path3 == -1)
            {
                return -1;
            }

            copy = IntMap.Clone() as int[,];
            startPoint = endPoint;
            endPoint = new Point(Convert.ToInt32(TurningPoint4.x), Convert.ToInt32(TurningPoint4.y));
            copy[startPoint.x, startPoint.y] = 1;
            newList = new List<Point>();
            newList.Add(startPoint);
            int path4 = GetMazeLength(copy, newList, endPoint, 1);
            if (path4 == -1)
            {
                return -1;
            }

            copy = IntMap.Clone() as int[,];
            startPoint = endPoint;
            endPoint = new Point(Convert.ToInt32(TurningPoint5.x), Convert.ToInt32(TurningPoint5.y));
            copy[startPoint.x, startPoint.y] = 1;
            newList = new List<Point>();
            newList.Add(startPoint);
            int path5 = GetMazeLength(copy, newList, endPoint, 1);
            if (path5 == -1)
            {
                return -1;
            }

            copy = IntMap.Clone() as int[,];
            startPoint = endPoint;
            endPoint = new Point(Convert.ToInt32(Exit.x), Convert.ToInt32(Exit.y));
            copy[startPoint.x, startPoint.y] = 1;
            newList = new List<Point>();
            newList.Add(startPoint);
            int path6 = GetMazeLength(copy, newList, endPoint, 1);
            if (path6 == -1)
            {
                return -1;
            }

            return path1+path2+path3+path4+path5+path6;
        }


    }

    /// <summary>
    /// 递归函数，GetMazeLength()的辅助方法
    /// </summary>
    /// <param name="intMapCopy"></param>
    /// <param name="pList"></param>
    /// <param name="endPoint"></param>
    /// <param name="currentLength"></param>
    /// <returns></returns>
    private int GetMazeLength(int[,] intMapCopy, List<Point> pList, Point endPoint, int currentLength)
    {
        if (pList.Count == 0)
        {
            return -1;
        }

        List<Point> newList = new List<Point>();
        foreach (Point p in pList)
        {
            if (p.Equals(endPoint))
            {
                return currentLength;
            }
            else
            {
                if (intMapCopy[p.x+1,p.y] == 0)
                {
                    intMapCopy[p.x + 1, p.y] = currentLength;
                    newList.Add(new Point(p.x + 1, p.y));
                }

                if (intMapCopy[p.x - 1, p.y] == 0)
                {
                    intMapCopy[p.x - 1, p.y] = currentLength;
                    newList.Add(new Point(p.x - 1, p.y));
                }

                if (intMapCopy[p.x, p.y + 1] == 0)
                {
                    intMapCopy[p.x, p.y + 1] = currentLength;
                    newList.Add(new Point(p.x, p.y + 1));
                }

                if (intMapCopy[p.x, p.y - 1] == 0)
                {
                    intMapCopy[p.x, p.y - 1] = currentLength;
                    newList.Add(new Point(p.x, p.y - 1));
                }
            }
        }

        return GetMazeLength(intMapCopy, newList, endPoint, currentLength + 1);
    }
}

/// <summary>
/// 记录坐标
/// </summary>
struct Point
{
    public int x, y;

    public Point (int _x, int _y)
    {
        x = _x;
        y = _y;
    }
    
    public override bool Equals(object obj)
    {
        if (obj is Point)
        {
            Point a = (Point) obj;
            if(a.x==x && a.y==y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
}
