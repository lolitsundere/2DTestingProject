using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Events;
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
    public Text EnemyInfo;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Text ItemInfo1;
    public Text ItemInfo2;
    public Text ItemInfo3;
    public Text ItemInfo4;
    public Text ItemDescription;
    public Text TopText;
    public Button CombinePanelButton;
    public GameObject CombinePanel;
    public int Health;


    public HashSet<NavMeshSurface> NavSet = new HashSet<NavMeshSurface>();
    public int PlayerCount = 1;

    private const int WorldWidth = 39;
    private const int WorldHeight = 39;

    private int StageLevel = 1;
    private int PlayerExp = 0;
    private int PlayerLevel = 1;
    private int PlayerGold = 0;

    private readonly Vector2 Enter = new Vector2(5f, 33f);
    private readonly Vector2 Exit = new Vector2(33f, 5f);
    private readonly Vector2 TurningPoint1 = new Vector2(5f, 19f);
    private readonly Vector2 TurningPoint2 = new Vector2(33f, 19f);
    private readonly Vector2 TurningPoint3 = new Vector2(33f, 33f);
    private readonly Vector2 TurningPoint4 = new Vector2(19f, 33f);
    private readonly Vector2 TurningPoint5 = new Vector2(19f, 5f);

    private GameObject SelectedObject;
    private TowerManager.TowerType CombineTarget;

    private int EnemyPerLevel = 0;
    private int CurrentEnemyAcount = 0;

    private const int TowerPerTurn = 5;
    private List<GameObject> OneTurnTowerList = new List<GameObject>();
    private List<GameObject> TowerList = new List<GameObject>();

    private enum Phase{ConstructingTower,SecetingTower,EnemySpawning};
    private Phase CurrentPhase;

    private System.Random random = new System.Random();

    private Dictionary<GameObject, GameObject> EnemyDic = new Dictionary<GameObject, GameObject>();
    private Dictionary<GameObject, GameObject> InnerWallDic = new Dictionary<GameObject, GameObject>();


    private List<List<GameObject>> FloorMap = new List<List<GameObject>>();
    private int[,] IntMap = new int[WorldWidth,WorldHeight];


    private SpriteRenderer EnabledAttackRange;


    void Start()
    {
        CurrentPhase=Phase.ConstructingTower;
        CreateWorld();
        MazeLengthMessage.text = "迷宫长度:" + GetMazeLength();
        EnemyInfo.text = "下拨敌人: 普通敌人";
        Health = 100;

        CombinePanelButton.onClick.AddListener(() =>
        {
            CombinePanel.SetActive(true);

            HashSet<TowerManager.TowerType> ConstructingTowerSet = new HashSet<TowerManager.TowerType>();

            foreach (GameObject tower in OneTurnTowerList)
            {
                TowerManager.TowerType tt = TowerManager.GetTowerType(tower);
                if (!ConstructingTowerSet.Contains(tt))
                {
                    ConstructingTowerSet.Add(tt);
                }
            }

            foreach (TowerManager.TowerType tt in ConstructingTowerSet)
            {
                if (TowerManager.GetTowerTag(tt) != "Untagged")
                {
                    foreach (var go in GameObject.FindGameObjectsWithTag(TowerManager.GetTowerTag(tt)))
                    {
                        go.GetComponent<Text>().color = new Color32(0xF1,0xFF,0x00,0xFF);
                    }
                }
            }
        });
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
        TopText.text = String.Format("等级: {0} 经验: {1} 金钱: {2} HP:{3}/100", PlayerLevel, PlayerExp, PlayerGold, Health);

        if (SelectedObject != null && SelectedObject.tag == "Tower")
        {
            ItemInfo1.text = TowerManager.GetTowerName(TowerManager.GetTowerType(SelectedObject));
            ItemInfo2.text = String.Format("攻击力:{0}", Mathf.Round(SelectedObject.GetComponent<TowerController>().PhysicalDamage));
            ItemInfo3.text = String.Format("基础攻击间隔:{0}s", SelectedObject.GetComponent<TowerController>().BasicAttackTime);
            ItemInfo4.text = String.Format("攻击速度:{0}", SelectedObject.GetComponent<TowerController>().AttackSpeed);
            ItemDescription.text = SelectedObject.GetComponent<TowerController>().TowerDescription;
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
                    ItemInfo1.text = String.Format("生命值:{0}/{1}", Mathf.RoundToInt(SelectedObject.GetComponent<EnemyController>().Health), SelectedObject.GetComponent<EnemyController>().MaxHealth);
                    ItemInfo2.text = String.Format("护甲:{0}", SelectedObject.GetComponent<EnemyController>().Armor);
                    ItemInfo3.text = String.Format("魔法抗性:{0}%", SelectedObject.GetComponent<EnemyController>().MagicResistance * 100);
                    ItemInfo4.text = String.Format("移动速度:{0}", SelectedObject.GetComponent<EnemyController>().MovementSpeed);
                    ItemDescription.text = SelectedObject.GetComponent<EnemyController>().EnemyDescription;
                }
                if (CurrentEnemyAcount == EnemyPerLevel && EnemyDic.Count == 0)
                {
                    SortedDictionary<float, GameObject> towerDamageDic = new SortedDictionary<float, GameObject>(new DescendingComparer<float>());
                    foreach (GameObject tower in TowerList)
                    {
                        while (towerDamageDic.ContainsKey(tower.GetComponent<TowerController>().DamageDealed))
                        {
                            tower.GetComponent<TowerController>().DamageDealed--;
                        }
                        towerDamageDic.Add(tower.GetComponent<TowerController>().DamageDealed, tower);
                        tower.GetComponent<TowerController>().DamageDealed = 0;
                    }
                    foreach (var pair in towerDamageDic)
                    {
                        if (pair.Value.GetComponent<TowerController>().MVPLevel < 10)
                        {
                            pair.Value.GetComponent<TowerController>().MVPLevel++;
                            break;
                        }
                    }
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
                    StageLevel++;
                    EnemyInfo.text = EnemyManager.GetEenemyInfo(StageLevel);
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
                            var ec = go.GetComponent<EnemyController>();
                            Health -= Mathf.RoundToInt((0f + ec.MaxDamageToPlayer) * ec.Health / ec.MaxHealth + 1);
                            PlayerGold -= ec.ExperienceAndGold;
                            PlayerExp -= ec.ExperienceAndGold;
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
        PlayerExp += go.GetComponent<EnemyController>().ExperienceAndGold;
        PlayerGold += go.GetComponent<EnemyController>().ExperienceAndGold;
        if (PlayerExp >= 1700)
        {
            PlayerLevel = 5;
        }
        else if (PlayerExp >= 1050)
        {
            PlayerLevel = 4;
        }
        else if (PlayerExp >= 550)
        {
            PlayerLevel = 3;
        }
        else if (PlayerExp >= 200)
        {
            PlayerLevel = 2;
        }
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
        var enemyNav = enemy3D.transform.GetComponent<NavMeshAgent>();

        enemy.GetComponent<EnemyController>().nav = enemyNav;
        EnemyManager.SetEnemy(enemy.GetComponent<EnemyController>(), StageLevel, PlayerCount);
        float f = 0.275f;
        if (enemy.GetComponent<EnemyController>().IsFlying)
        {
            f = 0.8f;
        }
        enemy3D.transform.position = new Vector3(Enter.x, f, Enter.y);
        enemyNav.Warp(new Vector3(Enter.x, f, Enter.y));
        enemyNav.SetDestination(new Vector3(TurningPoint1.x, 0.275f, TurningPoint1.y));

        EnemyPerLevel = enemy.GetComponent<EnemyController>().MaxAmount;

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
        ItemInfo1.text = String.Format("生命值:{0}/{1}", Mathf.RoundToInt(SelectedObject.GetComponent<EnemyController>().Health), SelectedObject.GetComponent<EnemyController>().MaxHealth);
        ItemInfo2.text = String.Format("护甲:{0}", SelectedObject.GetComponent<EnemyController>().Armor);
        ItemInfo3.text = String.Format("魔法抗性:{0}%", SelectedObject.GetComponent<EnemyController>().MagicResistance*100);
        ItemInfo4.text = String.Format("移动速度:{0}", SelectedObject.GetComponent<EnemyController>().MovementSpeed);
        ItemDescription.text = SelectedObject.GetComponent<EnemyController>().EnemyDescription;
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

        var tower = Instantiate(BasicTowerList[random.Next(BasicTowerList.Count)], transform.GetChild(1).GetChild(5).transform);
        tower.transform.position = pos;
        switch (PlayerLevel)
        {
            case 1:
                tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                break;
            case 2:
                if (random.Next(5) == 0)
                {
                    tower.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                }
                else
                {
                    tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                break;
            case 3:
                int randomNumber = random.Next(10);
                if (randomNumber == 0)
                {
                    tower.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                }
                else if (randomNumber <= 3)
                {
                    tower.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                }
                else
                {
                    tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                break;
            case 4:
                randomNumber = random.Next(10);
                if (randomNumber == 0)
                {
                    tower.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                }
                else if (randomNumber <= 2)
                {
                    tower.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                }
                else if (randomNumber <= 5)
                {
                    tower.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                }
                else
                {
                    tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                break;
            case 5:
                randomNumber = random.Next(10);
                if (randomNumber == 0)
                {
                    tower.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
                }
                else if (randomNumber <= 2)
                {
                    tower.transform.localScale = new Vector3(0.8f, 0.8f, 0.8f);
                }
                else if (randomNumber <= 5)
                {
                    tower.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
                }
                else if (randomNumber <= 8)
                {
                    tower.transform.localScale = new Vector3(0.6f, 0.6f, 0.6f);
                }
                else
                {
                    tower.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                }
                break;
        }
        OneTurnTowerList.Add(tower);

        TowerManager.SettingTower(tower.GetComponent<TowerController>(), TowerManager.GetTowerType(tower));

        var highlight = (GameObject)Instantiate(Resources.Load("TowerConstructingHighlight"), tower.transform);
        highlight.transform.position = pos;
        highlight.transform.localScale = new Vector3(1f / tower.transform.localScale.x, 1f / tower.transform.localScale.y, 1f / tower.transform.localScale.z);

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
        ItemInfo2.text = String.Format("攻击力:{0}", Mathf.Round(SelectedObject.GetComponent<TowerController>().PhysicalDamage));
        ItemInfo3.text = String.Format("基础攻击间隔:{0}s", SelectedObject.GetComponent<TowerController>().BasicAttackTime);
        ItemInfo4.text = String.Format("攻击速度:{0}", SelectedObject.GetComponent<TowerController>().AttackSpeed);
        ItemDescription.text = SelectedObject.GetComponent<TowerController>().TowerDescription;

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
                            if (TowerCombiningManager.CanUpgrade(SelectedObject, tt))
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
                            else
                            {
                                CheckAdvanceCombine(tt, LuckyCombine);
                            }
                        }
                    }
                }
                break;
            case Phase.EnemySpawning:
                updateTowers = TowerCombiningManager.GetCombinableTowers(TowerList, false);
                if (updateTowers.ContainsKey(SelectedObject))
                {
                    foreach (TowerManager.TowerType tt in updateTowers[SelectedObject])
                    {
                        CheckAdvanceCombine(tt, Combine);
                    }
                }
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 生成高级合成按钮
    /// </summary>
    /// <param name="tt"></param>
    /// <param name="action"></param>
    private void CheckAdvanceCombine(TowerManager.TowerType tt, UnityAction action)
    {
        Button b = GetEmptyButtom();
        b.image.color = Color.white;
        b.GetComponentInChildren<Text>().text = "合成" + TowerManager.GetTowerName(tt);
        CombineTarget = tt;
        b.onClick = new Button.ButtonClickedEvent();
        b.onClick.AddListener(action);
    }

    /// <summary>
    /// 在选择防御塔时合成
    /// </summary>
    private void LuckyCombine()
    {
        GameObject go = Instantiate(Resources.Load(TowerManager.GetTowerFileName(CombineTarget)), transform.GetChild(1).GetChild(5)) as GameObject;
        go.transform.position = SelectedObject.transform.position;
        OneTurnTowerList.Remove(SelectedObject);
        Destroy(SelectedObject);
        TowerManager.SettingTower(go.GetComponent<TowerController>(), CombineTarget);
        go.GetComponent<ClickEventHandler>().ClickEvent += TowerClickedAction;
        SelectedObject = go;
        RemainSelectedTower();
    }
    /// <summary>
    /// 在消灭敌人时合成
    /// </summary>
    private void Combine()
    {
        GameObject go = Instantiate(Resources.Load(TowerManager.GetTowerFileName(CombineTarget)), transform.GetChild(1).GetChild(5)) as GameObject;
        go.transform.position = SelectedObject.transform.position;
        int MVP = 0;
        foreach (TowerManager.TowerType tt in TowerCombiningManager.CombineDic[CombineTarget])
        {
            if (tt == TowerManager.GetTowerType(SelectedObject))
            {
                continue;
            }
            foreach (GameObject t in TowerList)
            {
                if (TowerManager.GetTowerType(t) == tt)
                {
                    MVP += t.GetComponent<TowerController>().MVPLevel;
                    CreateInnerWall(t.transform.position);
                    TowerList.Remove(t);
                    Destroy(t);
                    break;
                }
            }
        }
        MVP += SelectedObject.GetComponent<TowerController>().MVPLevel;
        TowerList.Remove(SelectedObject);
        Destroy(SelectedObject);
        TowerManager.SettingTower(go.GetComponent<TowerController>(), CombineTarget);
        go.GetComponent<TowerController>().MVPLevel = MVP < 10 ? MVP : 10;
        go.GetComponent<ClickEventHandler>().ClickEvent += TowerClickedAction;
        SelectedObject = go;
        TowerList.Add(go);
        ClearUI();
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
            if (SelectedObject.transform.Find("TowerConstructingHighlight(Clone)"))
            {
                Destroy(SelectedObject.transform.Find("TowerConstructingHighlight(Clone)").gameObject);
            }
            OneTurnTowerList = new List<GameObject>();
            TowerList.Add(SelectedObject);
            ClearUI();
            ItemInfo1.text = TowerManager.GetTowerName(TowerManager.GetTowerType(SelectedObject));
            ItemInfo2.text = String.Format("攻击力:{0}", Mathf.RoundToInt(SelectedObject.GetComponent<TowerController>().PhysicalDamage));
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
    /// 返回一个没有使用的按钮
    /// </summary>
    /// <returns></returns>
    private Button GetEmptyButtom()
    {
        if (Button1.GetComponentInChildren<Text>().text == "")
        {
            return Button1;
        }
        else if (Button2.GetComponentInChildren<Text>().text == "")
        {
            return Button2;
        }
        else if (Button3.GetComponentInChildren<Text>().text == "")
        {
            return Button3;
        }
        else if (Button4.GetComponentInChildren<Text>().text == "")
        {
            return Button4;
        }
        else
        {
            return null;
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
        ItemDescription.text = "";
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
        ClearUI();
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

class DescendingComparer<T> : IComparer<T> where T : IComparable<T>
{
    public int Compare(T x, T y)
    {
        return y.CompareTo(x);
    }
}
