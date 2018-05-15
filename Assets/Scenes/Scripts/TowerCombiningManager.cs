using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCombiningManager : MonoBehaviour {

    public static Dictionary<TowerManager.TowerType, HashSet<TowerManager.TowerType>> CombineDic;

    private void Start()
    {
        CombineDic = new Dictionary<TowerManager.TowerType, HashSet<TowerManager.TowerType>>();

        HashSet<TowerManager.TowerType> set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.B1);
        set.Add(TowerManager.TowerType.Y1);
        set.Add(TowerManager.TowerType.D1);
        CombineDic.Add(TowerManager.TowerType.Sliver, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Q1);
        set.Add(TowerManager.TowerType.E1);
        set.Add(TowerManager.TowerType.G1);
        CombineDic.Add(TowerManager.TowerType.Malachite, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.R1);
        set.Add(TowerManager.TowerType.R2);
        set.Add(TowerManager.TowerType.P1);
        CombineDic.Add(TowerManager.TowerType.AsteriatedRuby, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.R3);
        set.Add(TowerManager.TowerType.Q2);
        set.Add(TowerManager.TowerType.Sliver);
        CombineDic.Add(TowerManager.TowerType.SliverKnight, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Y3);
        set.Add(TowerManager.TowerType.D2);
        set.Add(TowerManager.TowerType.Malachite);
        CombineDic.Add(TowerManager.TowerType.MalachiteHuge, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.G3);
        set.Add(TowerManager.TowerType.E3);
        set.Add(TowerManager.TowerType.B2);
        CombineDic.Add(TowerManager.TowerType.Jade, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.AsteriatedRuby);
        set.Add(TowerManager.TowerType.R4);
        set.Add(TowerManager.TowerType.P3);
        CombineDic.Add(TowerManager.TowerType.Volcano, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.D5);
        set.Add(TowerManager.TowerType.Y3);
        set.Add(TowerManager.TowerType.D3);
        CombineDic.Add(TowerManager.TowerType.PinkDiamond, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.PinkDiamond);
        set.Add(TowerManager.TowerType.Sliver);
        set.Add(TowerManager.TowerType.SliverKnight);
        CombineDic.Add(TowerManager.TowerType.PinkDiamondHuge, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.PinkDiamondHuge);
        set.Add(TowerManager.TowerType.P6);
        set.Add(TowerManager.TowerType.D6);
        CombineDic.Add(TowerManager.TowerType.KDiamond, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Y5);
        set.Add(TowerManager.TowerType.E3);
        set.Add(TowerManager.TowerType.B2);
        CombineDic.Add(TowerManager.TowerType.Uranium238, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Uranium238);
        set.Add(TowerManager.TowerType.Malachite);
        set.Add(TowerManager.TowerType.MalachiteHuge);
        CombineDic.Add(TowerManager.TowerType.Uranium235, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Uranium235);
        set.Add(TowerManager.TowerType.Q6);
        set.Add(TowerManager.TowerType.Y6);
        CombineDic.Add(TowerManager.TowerType.DepletedKyparium, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.R5);
        set.Add(TowerManager.TowerType.Q4);
        set.Add(TowerManager.TowerType.P3);
        CombineDic.Add(TowerManager.TowerType.BloodStone, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.R2);
        set.Add(TowerManager.TowerType.BloodStone);
        set.Add(TowerManager.TowerType.Volcano);
        CombineDic.Add(TowerManager.TowerType.BloodStoneAntique, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.BloodStoneAntique);
        set.Add(TowerManager.TowerType.R6);
        set.Add(TowerManager.TowerType.G6);
        CombineDic.Add(TowerManager.TowerType.TheCrownPrince, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.G4);
        set.Add(TowerManager.TowerType.R3);
        set.Add(TowerManager.TowerType.P2);
        CombineDic.Add(TowerManager.TowerType.Quartz, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Jade);
        set.Add(TowerManager.TowerType.B4);
        set.Add(TowerManager.TowerType.Q3);
        CombineDic.Add(TowerManager.TowerType.GreyJade, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.GreyJade);
        set.Add(TowerManager.TowerType.G4);
        set.Add(TowerManager.TowerType.P2);
        CombineDic.Add(TowerManager.TowerType.MonkeyKingJade, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.MonkeyKingJade);
        set.Add(TowerManager.TowerType.D6);
        set.Add(TowerManager.TowerType.B6);
        CombineDic.Add(TowerManager.TowerType.GullinanDiamond, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Jade);
        set.Add(TowerManager.TowerType.Quartz);
        set.Add(TowerManager.TowerType.G3);
        CombineDic.Add(TowerManager.TowerType.ChineseJade, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.P4);
        set.Add(TowerManager.TowerType.Quartz);
        set.Add(TowerManager.TowerType.Y2);
        CombineDic.Add(TowerManager.TowerType.Lazurite, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Lazurite);
        set.Add(TowerManager.TowerType.R6);
        set.Add(TowerManager.TowerType.Y6);
        CombineDic.Add(TowerManager.TowerType.GoldenJubilee, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.P5);
        set.Add(TowerManager.TowerType.P4);
        set.Add(TowerManager.TowerType.D2);
        CombineDic.Add(TowerManager.TowerType.Gold, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Gold);
        set.Add(TowerManager.TowerType.P5);
        set.Add(TowerManager.TowerType.Q2);
        CombineDic.Add(TowerManager.TowerType.EgyptGold, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.G5);
        set.Add(TowerManager.TowerType.B4);
        set.Add(TowerManager.TowerType.Y2);
        CombineDic.Add(TowerManager.TowerType.DarkEmerald, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Gold);
        set.Add(TowerManager.TowerType.DarkEmerald);
        set.Add(TowerManager.TowerType.D3);
        CombineDic.Add(TowerManager.TowerType.EmeraldGolem, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Q5);
        set.Add(TowerManager.TowerType.E4);
        set.Add(TowerManager.TowerType.G2);
        CombineDic.Add(TowerManager.TowerType.ParaibaTourmaline, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.ParaibaTourmaline);
        set.Add(TowerManager.TowerType.DarkEmerald);
        set.Add(TowerManager.TowerType.G2);
        CombineDic.Add(TowerManager.TowerType.ElaboratelyCarvedTourmaline, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.ElaboratelyCarvedTourmaline);
        set.Add(TowerManager.TowerType.G6);
        set.Add(TowerManager.TowerType.P6);
        CombineDic.Add(TowerManager.TowerType.SapphireStarOfAdam, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.Q4);
        set.Add(TowerManager.TowerType.D4);
        set.Add(TowerManager.TowerType.E2);
        CombineDic.Add(TowerManager.TowerType.DeepSeaPearl, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.E5);
        set.Add(TowerManager.TowerType.D4);
        set.Add(TowerManager.TowerType.Q3);
        CombineDic.Add(TowerManager.TowerType.ChrysoberylCatsEye, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.ChrysoberylCatsEye);
        set.Add(TowerManager.TowerType.DeepSeaPearl);
        set.Add(TowerManager.TowerType.E4);
        CombineDic.Add(TowerManager.TowerType.RedCoral, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.DeepSeaPearl);
        set.Add(TowerManager.TowerType.G5);
        set.Add(TowerManager.TowerType.D3);
        CombineDic.Add(TowerManager.TowerType.NaturalZumurud, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.RedCoral);
        set.Add(TowerManager.TowerType.E6);
        set.Add(TowerManager.TowerType.Q6);
        CombineDic.Add(TowerManager.TowerType.CarmenLucia, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.B5);
        set.Add(TowerManager.TowerType.Y4);
        set.Add(TowerManager.TowerType.R4);
        CombineDic.Add(TowerManager.TowerType.YellowSapphire, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.YellowSapphire);
        set.Add(TowerManager.TowerType.BloodStone);
        set.Add(TowerManager.TowerType.B5);
        CombineDic.Add(TowerManager.TowerType.NorthernSabersEye, set);

        set = new HashSet<TowerManager.TowerType>();
        set.Add(TowerManager.TowerType.NorthernSabersEye);
        set.Add(TowerManager.TowerType.B6);
        set.Add(TowerManager.TowerType.E6);
        CombineDic.Add(TowerManager.TowerType.StarSapphire, set);
    }

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

            if (towerDic.ContainsKey(TowerManager.TowerType.R2) && towerDic[TowerManager.TowerType.R2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R3);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R2) && towerDic[TowerManager.TowerType.R2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R3) && towerDic[TowerManager.TowerType.R3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R3) && towerDic[TowerManager.TowerType.R3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R4) && towerDic[TowerManager.TowerType.R4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R4) && towerDic[TowerManager.TowerType.R4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R5) && towerDic[TowerManager.TowerType.R5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.R6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.R5) && towerDic[TowerManager.TowerType.R5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.B2) && towerDic[TowerManager.TowerType.B2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.B2) && towerDic[TowerManager.TowerType.B2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B3) && towerDic[TowerManager.TowerType.B3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.B3) && towerDic[TowerManager.TowerType.B3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B4) && towerDic[TowerManager.TowerType.B4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.B4) && towerDic[TowerManager.TowerType.B4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B5) && towerDic[TowerManager.TowerType.B5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.B6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.B5) && towerDic[TowerManager.TowerType.B5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

                        if (towerDic.ContainsKey(TowerManager.TowerType.Q2) && towerDic[TowerManager.TowerType.Q2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Q2) && towerDic[TowerManager.TowerType.Q2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Q3) && towerDic[TowerManager.TowerType.Q3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Q3) && towerDic[TowerManager.TowerType.Q3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Q4) && towerDic[TowerManager.TowerType.Q4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Q4) && towerDic[TowerManager.TowerType.Q4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Q5) && towerDic[TowerManager.TowerType.Q5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Q6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Q5) && towerDic[TowerManager.TowerType.Q5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.G2) && towerDic[TowerManager.TowerType.G2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.G2) && towerDic[TowerManager.TowerType.G2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.G3) && towerDic[TowerManager.TowerType.G3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.G3) && towerDic[TowerManager.TowerType.G3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.G4) && towerDic[TowerManager.TowerType.G4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.G4) && towerDic[TowerManager.TowerType.G4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.G5) && towerDic[TowerManager.TowerType.G5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.G6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.G5) && towerDic[TowerManager.TowerType.G5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.E2) && towerDic[TowerManager.TowerType.E2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.E2) && towerDic[TowerManager.TowerType.E2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E3) && towerDic[TowerManager.TowerType.E3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.E3) && towerDic[TowerManager.TowerType.E3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E4) && towerDic[TowerManager.TowerType.E4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.E4) && towerDic[TowerManager.TowerType.E4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E5) && towerDic[TowerManager.TowerType.E5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.E6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.E5) && towerDic[TowerManager.TowerType.E5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.Y2) && towerDic[TowerManager.TowerType.Y2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Y2) && towerDic[TowerManager.TowerType.Y2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Y3) && towerDic[TowerManager.TowerType.Y3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Y3) && towerDic[TowerManager.TowerType.Y3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Y4) && towerDic[TowerManager.TowerType.Y4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Y4) && towerDic[TowerManager.TowerType.Y4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.Y5) && towerDic[TowerManager.TowerType.Y5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.Y6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.Y5) && towerDic[TowerManager.TowerType.Y5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.D2) && towerDic[TowerManager.TowerType.D2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.D2) && towerDic[TowerManager.TowerType.D2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.D3) && towerDic[TowerManager.TowerType.D3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.D3) && towerDic[TowerManager.TowerType.D3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.D4) && towerDic[TowerManager.TowerType.D4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.D4) && towerDic[TowerManager.TowerType.D4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.D5) && towerDic[TowerManager.TowerType.D5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.D6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.D5) && towerDic[TowerManager.TowerType.D5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
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

            if (towerDic.ContainsKey(TowerManager.TowerType.P2) && towerDic[TowerManager.TowerType.P2].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P3);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.P2) && towerDic[TowerManager.TowerType.P2].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P4);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P3) && towerDic[TowerManager.TowerType.P3].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P4);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.P3) && towerDic[TowerManager.TowerType.P3].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P5);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P4) && towerDic[TowerManager.TowerType.P4].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P5);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.P4) && towerDic[TowerManager.TowerType.P4].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P6);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P5) && towerDic[TowerManager.TowerType.P5].Count >= 2)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.P6);
                }
            }


            if (towerDic.ContainsKey(TowerManager.TowerType.P5) && towerDic[TowerManager.TowerType.P5].Count >= 4)
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheGreatStone);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.P1) && towerDic.ContainsKey(TowerManager.TowerType.P2) && towerDic.ContainsKey(TowerManager.TowerType.P3) && towerDic.ContainsKey(TowerManager.TowerType.P4) && towerDic.ContainsKey(TowerManager.TowerType.P5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.P1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.P2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.P3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.P4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.P5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
            }
            if (towerDic.ContainsKey(TowerManager.TowerType.Q1) && towerDic.ContainsKey(TowerManager.TowerType.Q2) && towerDic.ContainsKey(TowerManager.TowerType.Q3) && towerDic.ContainsKey(TowerManager.TowerType.Q4) && towerDic.ContainsKey(TowerManager.TowerType.Q5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Q5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.KDiamond);
                }
            }
            if (towerDic.ContainsKey(TowerManager.TowerType.R1) && towerDic.ContainsKey(TowerManager.TowerType.R2) && towerDic.ContainsKey(TowerManager.TowerType.R3) && towerDic.ContainsKey(TowerManager.TowerType.R4) && towerDic.ContainsKey(TowerManager.TowerType.R5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.R1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheCrownPrince);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.R2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheCrownPrince);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.R3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheCrownPrince);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.R4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheCrownPrince);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.R5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.TheCrownPrince);
                }
            }
            if (towerDic.ContainsKey(TowerManager.TowerType.D1) && towerDic.ContainsKey(TowerManager.TowerType.D2) && towerDic.ContainsKey(TowerManager.TowerType.D3) && towerDic.ContainsKey(TowerManager.TowerType.D4) && towerDic.ContainsKey(TowerManager.TowerType.D5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.D1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GullinanDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.D2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GullinanDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.D3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GullinanDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.D4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GullinanDiamond);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.D5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GullinanDiamond);
                }
            }
            if (towerDic.ContainsKey(TowerManager.TowerType.Y1) && towerDic.ContainsKey(TowerManager.TowerType.Y2) && towerDic.ContainsKey(TowerManager.TowerType.Y3) && towerDic.ContainsKey(TowerManager.TowerType.Y4) && towerDic.ContainsKey(TowerManager.TowerType.Y5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GoldenJubilee);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GoldenJubilee);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GoldenJubilee);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GoldenJubilee);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.Y5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.GoldenJubilee);
                }
            }
            if (towerDic.ContainsKey(TowerManager.TowerType.G1) && towerDic.ContainsKey(TowerManager.TowerType.G2) && towerDic.ContainsKey(TowerManager.TowerType.G3) && towerDic.ContainsKey(TowerManager.TowerType.G4) && towerDic.ContainsKey(TowerManager.TowerType.G5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.G1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.SapphireStarOfAdam);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.G2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.SapphireStarOfAdam);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.G3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.SapphireStarOfAdam);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.G4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.SapphireStarOfAdam);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.G5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.SapphireStarOfAdam);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.E1) && towerDic.ContainsKey(TowerManager.TowerType.E2) && towerDic.ContainsKey(TowerManager.TowerType.E3) && towerDic.ContainsKey(TowerManager.TowerType.E4) && towerDic.ContainsKey(TowerManager.TowerType.E5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.E1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.CarmenLucia);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.E2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.CarmenLucia);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.E3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.CarmenLucia);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.E4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.CarmenLucia);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.E5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.CarmenLucia);
                }
            }

            if (towerDic.ContainsKey(TowerManager.TowerType.B1) && towerDic.ContainsKey(TowerManager.TowerType.B2) && towerDic.ContainsKey(TowerManager.TowerType.B3) && towerDic.ContainsKey(TowerManager.TowerType.B4) && towerDic.ContainsKey(TowerManager.TowerType.B5))
            {
                foreach (GameObject go in towerDic[TowerManager.TowerType.B1])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.StarSapphire);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.B2])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.StarSapphire);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.B3])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.StarSapphire);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.B4])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.StarSapphire);
                }
                foreach (GameObject go in towerDic[TowerManager.TowerType.B5])
                {
                    if (!result.ContainsKey(go))
                    {
                        result.Add(go, new List<TowerManager.TowerType>());
                    }
                    result[go].Add(TowerManager.TowerType.StarSapphire);
                }
            }

            #endregion
        }

        foreach (TowerManager.TowerType combiner in CombineDic.Keys)
        {
            bool canCombine = true;
            foreach (TowerManager.TowerType combinee in CombineDic[combiner])
            {
                if (!towerDic.ContainsKey(combinee))
                {
                    canCombine = false;
                    break;
                }
            }
            if (canCombine)
            {
                foreach (TowerManager.TowerType combinee in CombineDic[combiner])
                {
                    foreach (GameObject go in towerDic[combinee])
                    {
                        if (!result.ContainsKey(go))
                        {
                            result.Add(go, new List<TowerManager.TowerType>());
                        }
                        result[go].Add(combiner);
                    }
                }
            }
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
