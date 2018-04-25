using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCombiningManager : MonoBehaviour {

    /// <summary>
    /// 判断输入数组中所含的防御塔是否可以进行升级、合成操作
    /// </summary>
    /// <param name="towers"></param>
    /// <param name="inTurn">能否进行升级操作</param>
    /// <returns></returns>
    public static Dictionary<GameObject, List<TowerManager.TowerType>> GetCombinableTowers(List<GameObject> towers, bool inTurn)
    {
        Dictionary<TowerManager.TowerType, List<GameObject>> towerDic = new Dictionary<TowerManager.TowerType, List<GameObject>>();

        foreach (GameObject tower in towers)
        {
            TowerManager.TowerType tt = TowerManager.GetTowerType(tower);
            if (!towerDic.ContainsKey(tt))
            {
                towerDic.Add(tt, new List<GameObject>());
            }

            towerDic[tt].Add(tower);
        }

        Dictionary<GameObject, List<TowerManager.TowerType>> result = new Dictionary<GameObject, List<TowerManager.TowerType>>();

        if (inTurn)
        {
            #region 判断升级

            if (towerDic.ContainsKey(TowerManager.TowerType.R1) && towerDic[TowerManager.TowerType.R1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R1) && towerDic[TowerManager.TowerType.R1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B1) && towerDic[TowerManager.TowerType.B1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B1) && towerDic[TowerManager.TowerType.B1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Q1) && towerDic[TowerManager.TowerType.Q1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Q1) && towerDic[TowerManager.TowerType.Q1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.G1) && towerDic[TowerManager.TowerType.G1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.G1) && towerDic[TowerManager.TowerType.G1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E1) && towerDic[TowerManager.TowerType.E1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E1) && towerDic[TowerManager.TowerType.E1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Y1) && towerDic[TowerManager.TowerType.Y1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Y1) && towerDic[TowerManager.TowerType.Y1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P1) && towerDic[TowerManager.TowerType.P1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P1) && towerDic[TowerManager.TowerType.P1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.D1) && towerDic[TowerManager.TowerType.D1].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D2);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.D1) && towerDic[TowerManager.TowerType.D1].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D3);
                }
            }

            #endregion
        }

        return result;
    }

   /// <summary>
   /// 判断输入物体是否能升级成为输入类型的防御塔
   /// </summary>
   /// <param name="tower"></param>
   /// <param name="tt"></param>
   /// <returns></returns>
    public static bool CanUpgrade(GameObject tower, TowerManager.TowerType tt)
    {
        if ((TowerManager.GetTowerType(tower) == TowerManager.TowerType.B1 && tt == TowerManager.TowerType.B2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B2 && tt == TowerManager.TowerType.B3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B3 && tt == TowerManager.TowerType.B4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B4 && tt == TowerManager.TowerType.B5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B5 && tt == TowerManager.TowerType.B6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R1 && tt == TowerManager.TowerType.R2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R2 && tt == TowerManager.TowerType.R3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R3 && tt == TowerManager.TowerType.R4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R4 && tt == TowerManager.TowerType.R5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R5 && tt == TowerManager.TowerType.R6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q1 && tt == TowerManager.TowerType.Q2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q2 && tt == TowerManager.TowerType.Q3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q3 && tt == TowerManager.TowerType.Q4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q4 && tt == TowerManager.TowerType.Q5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q5 && tt == TowerManager.TowerType.Q6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G1 && tt == TowerManager.TowerType.G2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G2 && tt == TowerManager.TowerType.G3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G3 && tt == TowerManager.TowerType.G4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G4 && tt == TowerManager.TowerType.G5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G5 && tt == TowerManager.TowerType.G6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E1 && tt == TowerManager.TowerType.E2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E2 && tt == TowerManager.TowerType.E3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E3 && tt == TowerManager.TowerType.E4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E4 && tt == TowerManager.TowerType.E5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E5 && tt == TowerManager.TowerType.E6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P1 && tt == TowerManager.TowerType.P2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P2 && tt == TowerManager.TowerType.P3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P3 && tt == TowerManager.TowerType.P4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P4 && tt == TowerManager.TowerType.P5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P5 && tt == TowerManager.TowerType.P6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y1 && tt == TowerManager.TowerType.Y2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y2 && tt == TowerManager.TowerType.Y3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y3 && tt == TowerManager.TowerType.Y4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y4 && tt == TowerManager.TowerType.Y5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y5 && tt == TowerManager.TowerType.Y6) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D1 && tt == TowerManager.TowerType.D2) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D2 && tt == TowerManager.TowerType.D3) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D3 && tt == TowerManager.TowerType.D4) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D4 && tt == TowerManager.TowerType.D5) ||
            (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D5 && tt == TowerManager.TowerType.D6))
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
     public static bool CanSuperUpgrade(GameObject tower, TowerManager.TowerType tt)
     {
         if ((TowerManager.GetTowerType(tower) == TowerManager.TowerType.B1 && tt == TowerManager.TowerType.B3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B2 && tt == TowerManager.TowerType.B4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B3 && tt == TowerManager.TowerType.B5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.B4 && tt == TowerManager.TowerType.B6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R1 && tt == TowerManager.TowerType.R3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R2 && tt == TowerManager.TowerType.R4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R3 && tt == TowerManager.TowerType.R5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.R4 && tt == TowerManager.TowerType.R6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q1 && tt == TowerManager.TowerType.Q3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q2 && tt == TowerManager.TowerType.Q4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q3 && tt == TowerManager.TowerType.Q5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Q4 && tt == TowerManager.TowerType.Q6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G1 && tt == TowerManager.TowerType.G3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G2 && tt == TowerManager.TowerType.G4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G3 && tt == TowerManager.TowerType.G5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.G4 && tt == TowerManager.TowerType.G6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E1 && tt == TowerManager.TowerType.E3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E2 && tt == TowerManager.TowerType.E4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E3 && tt == TowerManager.TowerType.E5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.E4 && tt == TowerManager.TowerType.E6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P1 && tt == TowerManager.TowerType.P3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P2 && tt == TowerManager.TowerType.P4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P3 && tt == TowerManager.TowerType.P5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.P4 && tt == TowerManager.TowerType.P6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y1 && tt == TowerManager.TowerType.Y3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y2 && tt == TowerManager.TowerType.Y4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y3 && tt == TowerManager.TowerType.Y5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.Y4 && tt == TowerManager.TowerType.Y6) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D1 && tt == TowerManager.TowerType.D3) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D2 && tt == TowerManager.TowerType.D4) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D3 && tt == TowerManager.TowerType.D5) ||
             (TowerManager.GetTowerType(tower) == TowerManager.TowerType.D4 && tt == TowerManager.TowerType.D6))
         {
             return true;
         }
         else
         {
             return false;
         }
     }
}
