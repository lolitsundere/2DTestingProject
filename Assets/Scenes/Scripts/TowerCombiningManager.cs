using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCombiningManager : MonoBehaviour {

    public enum TowerType
    { Unkown, R1, R2, R3, R4, R5, R6, B1, B2, B3, B4, B5, B6, Y1, Y2, Y3, Y4, Y5, Y6, G1, G2, G3, G4, G5, G6, P1, P2, P3, P4, P5, P6, Q1, Q2, Q3, Q4, Q5, Q6, D1, D2, D3, D4, D5, D6, E1, E2, E3, E4, E5, E6 };


    /// <summary>
    /// 判断输入数组中所含的防御塔是否可以进行升级、合成操作
    /// </summary>
    /// <param name="towers"></param>
    /// <param name="inTurn">能否进行升级操作</param>
    /// <returns></returns>
    public static Dictionary<GameObject, List<TowerType>> GetCombinableTowers(List<GameObject> towers, bool inTurn)
    {
        Dictionary<TowerType, List<GameObject>> towerDic = new Dictionary<TowerType, List<GameObject>>();

        foreach (GameObject tower in towers)
        {
            TowerType tt = GetTowerType(tower);
            if (!towerDic.ContainsKey(tt))
            {
                towerDic.Add(tt, new List<GameObject>());
            }

            towerDic[tt].Add(tower);
        }

        Dictionary<GameObject, List<TowerType>> result = new Dictionary<GameObject, List<TowerType>>();

        if (inTurn)
        {
            #region 判断升级

            if (towerDic.ContainsKey(TowerType.R1) && towerDic[TowerType.R1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.R1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.R2);
                }
            }

            if (towerDic.ContainsKey(TowerType.R1) && towerDic[TowerType.R1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.R1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.R3);
                }
            }

            if (towerDic.ContainsKey(TowerType.B1) && towerDic[TowerType.B1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.B1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.B2);
                }
            }

            if (towerDic.ContainsKey(TowerType.B1) && towerDic[TowerType.B1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.B1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.B3);
                }
            }

            if (towerDic.ContainsKey(TowerType.Q1) && towerDic[TowerType.Q1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.Q1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.Q2);
                }
            }

            if (towerDic.ContainsKey(TowerType.Q1) && towerDic[TowerType.Q1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.Q1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.Q3);
                }
            }

            if (towerDic.ContainsKey(TowerType.G1) && towerDic[TowerType.G1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.G1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.G2);
                }
            }

            if (towerDic.ContainsKey(TowerType.G1) && towerDic[TowerType.G1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.G1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.G3);
                }
            }

            if (towerDic.ContainsKey(TowerType.E1) && towerDic[TowerType.E1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.E1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.E2);
                }
            }

            if (towerDic.ContainsKey(TowerType.E1) && towerDic[TowerType.E1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.E1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.E3);
                }
            }

            if (towerDic.ContainsKey(TowerType.Y1) && towerDic[TowerType.Y1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.Y1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.Y2);
                }
            }

            if (towerDic.ContainsKey(TowerType.Y1) && towerDic[TowerType.Y1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.Y1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.Y3);
                }
            }

            if (towerDic.ContainsKey(TowerType.P1) && towerDic[TowerType.P1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.P1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.P2);
                }
            }

            if (towerDic.ContainsKey(TowerType.P1) && towerDic[TowerType.P1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.P1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.P3);
                }
            }

            if (towerDic.ContainsKey(TowerType.D1) && towerDic[TowerType.D1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerType.D1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.D2);
                }
            }

            if (towerDic.ContainsKey(TowerType.D1) && towerDic[TowerType.D1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerType.D1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerType>());
                    }
                    result[go].Add(TowerType.D3);
                }
            }

            #endregion
        }

        return result;
    }

    /// <summary>
    /// 判断输入物体的防御塔类型
    /// </summary>
    /// <param name="tower"></param>
    /// <returns></returns>
    public static TowerType GetTowerType(GameObject tower)
    {
        #region 紫宝石
        if (tower.name.StartsWith("Ame"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.P1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.P2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.P3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.P4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.P5;
            }
            else
            {
                return TowerType.P6;
            }
        }
        #endregion

        #region 海晶石
        else if (tower.name.StartsWith("Aqu"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.Q1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.Q2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.Q3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.Q4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.Q5;
            }
            else
            {
                return TowerType.Q6;
            }
        }
        #endregion

        #region 钻石
        else if (tower.name.StartsWith("Dia"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.D1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.D2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.D3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.D4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.D5;
            }
            else
            {
                return TowerType.D6;
            }
        }
        #endregion

        #region 祖母绿
        else if (tower.name.StartsWith("Eme"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.G1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.G2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.G3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.G4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.G5;
            }
            else
            {
                return TowerType.G6;
            }
        }
        #endregion

        #region 蛋白石
        else if (tower.name.StartsWith("Opa"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.E1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.E2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.E3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.E4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.E5;
            }
            else
            {
                return TowerType.E6;
            }
        }
        #endregion

        #region 红宝石
        else if (tower.name.StartsWith("Rub"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.R1;

            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.R2;

            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.R3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.R4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.R5;
            }
            else
            {
                return TowerType.R6;
            }
        }
        #endregion

        #region 蓝宝石
        else if (tower.name.StartsWith("Sap"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.B1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.B2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.B3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.B4;

            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.B5;
            }
            else
            {
                return TowerType.B6;
            }
        }
        #endregion

        #region 黄宝石
        else if (tower.name.StartsWith("Top"))
        {
            if (tower.transform.localScale.x < 0.51)
            {
                return TowerType.Y1;
            }
            else if (tower.transform.localScale.x < 0.61)
            {
                return TowerType.Y2;
            }
            else if (tower.transform.localScale.x < 0.71)
            {
                return TowerType.Y3;
            }
            else if (tower.transform.localScale.x < 0.81)
            {
                return TowerType.Y4;
            }
            else if (tower.transform.localScale.x < 0.91)
            {
                return TowerType.Y5;
            }
            else
            {
                return TowerType.Y6;
            }
        }
        #endregion

        else return TowerType.Unkown;

    }

   /// <summary>
   /// 判断输入物体是否能升级成为输入类型的防御塔
   /// </summary>
   /// <param name="tower"></param>
   /// <param name="tt"></param>
   /// <returns></returns>
    public static bool CanUpgrade(GameObject tower, TowerType tt)
    {
        if ((GetTowerType(tower) == TowerType.B1 && tt == TowerType.B2) ||
            (GetTowerType(tower) == TowerType.B2 && tt == TowerType.B3) ||
            (GetTowerType(tower) == TowerType.B3 && tt == TowerType.B4) ||
            (GetTowerType(tower) == TowerType.B4 && tt == TowerType.B5) ||
            (GetTowerType(tower) == TowerType.B5 && tt == TowerType.B6) ||
            (GetTowerType(tower) == TowerType.R1 && tt == TowerType.R2) ||
            (GetTowerType(tower) == TowerType.R2 && tt == TowerType.R3) ||
            (GetTowerType(tower) == TowerType.R3 && tt == TowerType.R4) ||
            (GetTowerType(tower) == TowerType.R4 && tt == TowerType.R5) ||
            (GetTowerType(tower) == TowerType.R5 && tt == TowerType.R6) ||
            (GetTowerType(tower) == TowerType.Q1 && tt == TowerType.Q2) ||
            (GetTowerType(tower) == TowerType.Q2 && tt == TowerType.Q3) ||
            (GetTowerType(tower) == TowerType.Q3 && tt == TowerType.Q4) ||
            (GetTowerType(tower) == TowerType.Q4 && tt == TowerType.Q5) ||
            (GetTowerType(tower) == TowerType.Q5 && tt == TowerType.Q6) ||
            (GetTowerType(tower) == TowerType.G1 && tt == TowerType.G2) ||
            (GetTowerType(tower) == TowerType.G2 && tt == TowerType.G3) ||
            (GetTowerType(tower) == TowerType.G3 && tt == TowerType.G4) ||
            (GetTowerType(tower) == TowerType.G4 && tt == TowerType.G5) ||
            (GetTowerType(tower) == TowerType.G5 && tt == TowerType.G6) ||
            (GetTowerType(tower) == TowerType.E1 && tt == TowerType.E2) ||
            (GetTowerType(tower) == TowerType.E2 && tt == TowerType.E3) ||
            (GetTowerType(tower) == TowerType.E3 && tt == TowerType.E4) ||
            (GetTowerType(tower) == TowerType.E4 && tt == TowerType.E5) ||
            (GetTowerType(tower) == TowerType.E5 && tt == TowerType.E6) ||
            (GetTowerType(tower) == TowerType.P1 && tt == TowerType.P2) ||
            (GetTowerType(tower) == TowerType.P2 && tt == TowerType.P3) ||
            (GetTowerType(tower) == TowerType.P3 && tt == TowerType.P4) ||
            (GetTowerType(tower) == TowerType.P4 && tt == TowerType.P5) ||
            (GetTowerType(tower) == TowerType.P5 && tt == TowerType.P6) ||
            (GetTowerType(tower) == TowerType.Y1 && tt == TowerType.Y2) ||
            (GetTowerType(tower) == TowerType.Y2 && tt == TowerType.Y3) ||
            (GetTowerType(tower) == TowerType.Y3 && tt == TowerType.Y4) ||
            (GetTowerType(tower) == TowerType.Y4 && tt == TowerType.Y5) ||
            (GetTowerType(tower) == TowerType.Y5 && tt == TowerType.Y6) ||
            (GetTowerType(tower) == TowerType.D1 && tt == TowerType.D2) ||
            (GetTowerType(tower) == TowerType.D2 && tt == TowerType.D3) ||
            (GetTowerType(tower) == TowerType.D3 && tt == TowerType.D4) ||
            (GetTowerType(tower) == TowerType.D4 && tt == TowerType.D5) ||
            (GetTowerType(tower) == TowerType.D5 && tt == TowerType.D6))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// 判断输入物体是否能超级升级成为输入的防御塔
    /// </summary>
    /// <param name="tower"></param>
    /// <param name="tt"></param>
    /// <returns></returns>
     public static bool CanSuperUpgrade(GameObject tower, TowerType tt)
     {
         if ((GetTowerType(tower) == TowerType.B1 && tt == TowerType.B3) ||
             (GetTowerType(tower) == TowerType.B2 && tt == TowerType.B4) ||
             (GetTowerType(tower) == TowerType.B3 && tt == TowerType.B5) ||
             (GetTowerType(tower) == TowerType.B4 && tt == TowerType.B6) ||
             (GetTowerType(tower) == TowerType.R1 && tt == TowerType.R3) ||
             (GetTowerType(tower) == TowerType.R2 && tt == TowerType.R4) ||
             (GetTowerType(tower) == TowerType.R3 && tt == TowerType.R5) ||
             (GetTowerType(tower) == TowerType.R4 && tt == TowerType.R6) ||
             (GetTowerType(tower) == TowerType.Q1 && tt == TowerType.Q3) ||
             (GetTowerType(tower) == TowerType.Q2 && tt == TowerType.Q4) ||
             (GetTowerType(tower) == TowerType.Q3 && tt == TowerType.Q5) ||
             (GetTowerType(tower) == TowerType.Q4 && tt == TowerType.Q6) ||
             (GetTowerType(tower) == TowerType.G1 && tt == TowerType.G3) ||
             (GetTowerType(tower) == TowerType.G2 && tt == TowerType.G4) ||
             (GetTowerType(tower) == TowerType.G3 && tt == TowerType.G5) ||
             (GetTowerType(tower) == TowerType.G4 && tt == TowerType.G6) ||
             (GetTowerType(tower) == TowerType.E1 && tt == TowerType.E3) ||
             (GetTowerType(tower) == TowerType.E2 && tt == TowerType.E4) ||
             (GetTowerType(tower) == TowerType.E3 && tt == TowerType.E5) ||
             (GetTowerType(tower) == TowerType.E4 && tt == TowerType.E6) ||
             (GetTowerType(tower) == TowerType.P1 && tt == TowerType.P3) ||
             (GetTowerType(tower) == TowerType.P2 && tt == TowerType.P4) ||
             (GetTowerType(tower) == TowerType.P3 && tt == TowerType.P5) ||
             (GetTowerType(tower) == TowerType.P4 && tt == TowerType.P6) ||
             (GetTowerType(tower) == TowerType.Y1 && tt == TowerType.Y3) ||
             (GetTowerType(tower) == TowerType.Y2 && tt == TowerType.Y4) ||
             (GetTowerType(tower) == TowerType.Y3 && tt == TowerType.Y5) ||
             (GetTowerType(tower) == TowerType.Y4 && tt == TowerType.Y6) ||
             (GetTowerType(tower) == TowerType.D1 && tt == TowerType.D3) ||
             (GetTowerType(tower) == TowerType.D2 && tt == TowerType.D4) ||
             (GetTowerType(tower) == TowerType.D3 && tt == TowerType.D5) ||
             (GetTowerType(tower) == TowerType.D4 && tt == TowerType.D6))
         {
             return true;
         }
         else
         {
             return false;
         }
     }
}
