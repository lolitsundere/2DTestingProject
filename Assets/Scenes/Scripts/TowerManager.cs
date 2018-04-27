using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerManager : MonoBehaviour
{
    public enum TowerType
    { Unkown, R1, R2, R3, R4, R5, R6, B1, B2, B3, B4, B5, B6, Y1, Y2, Y3, Y4, Y5, Y6, G1, G2, G3, G4, G5, G6,
        P1, P2, P3, P4, P5, P6, Q1, Q2, Q3, Q4, Q5, Q6, D1, D2, D3, D4, D5, D6, E1, E2, E3, E4, E5, E6,
        Sliver, Malachite, AsteriatedRuby };

    /// <summary>
    /// 设置输入防御塔的基础数值
    /// </summary>
    /// <param name="tower"></param>
    /// <param name="tt"></param>
    public static void SettingTower(TowerController tower,TowerType tt)
    {
        switch (tt)
        {
            case TowerType.B1:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect60;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减60移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B2:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B3:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect120;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减120移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B4:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect150;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减150移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B5:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect180;
                tower.TowerDescription = "防御塔特性:减少攻击目标的移动速度(减180移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B6:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 36;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect480;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减480移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.D1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 20;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 40;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 460;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.E1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 1;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect20;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加20)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect30;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加30)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 3;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect40;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加40)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect50;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加50)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect60;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加60)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect70;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加70)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.G1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect1;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒1点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect2;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒2点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect4;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒4点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect8;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒8点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.P1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 2;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect1;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减1点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 4;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect2;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减2点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 6;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect4;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减4点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 8;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect8;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减8点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 10;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect16;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减16点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 70;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.Q1:
                tower.AttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q2:
                tower.AttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.9;
                tower.PhysicalDamage = 4;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q3:
                tower.AttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.8;
                tower.PhysicalDamage = 8;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q4:
                tower.AttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 16;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q5:
                tower.AttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 24;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.R1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect1;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3格内敌人受到主攻击目标所受30%的伤害)";
                break;
            case TowerType.R2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect2;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3.5格内敌人受到主攻击目标所受40%的伤害)";
                break;
            case TowerType.R3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害)";
                break;
            case TowerType.R4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 24;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect4;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4.5格内敌人受到主攻击目标所受60%的伤害)";
                break;
            case TowerType.R5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 48;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect5;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(5格内敌人受到主攻击目标所受70%的伤害)";
                break;
            case TowerType.R6:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 150;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect6;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(7格内敌人受到主攻击目标所受100%的伤害)";
                break;
            case TowerType.Y1:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y2:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 6;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y3:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 9;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y4:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 18;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y5:
                tower.AttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 36;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y6:
                tower.AttackRange = 5000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 200;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Sliver:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.9;
                tower.PhysicalDamage = 25;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n高攻击\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.Malachite:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.8;
                tower.PhysicalDamage = 15;
                tower.MaxTargetAmount = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击三个目标)";
                break;
            case TowerType.AsteriatedRuby:
                tower.AttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 0;
                tower.BEffect = TowerController.BurnEffect.BurnEffect30; 
                tower.TowerDescription = "防御塔特性:\n灼烧攻击(5格内敌人每0.5秒受到30魔法伤害)";
                break;
        }
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

        else if (tower.name.StartsWith("Sliver"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.Sliver;
            }
            else
            {
                return TowerType.Unkown;
            }
        }

        else if (tower.name.StartsWith("Mala"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.Malachite;
            }
            else
            {
                return TowerType.Unkown;
            }
        }

        else if (tower.name.StartsWith("Aster"))
        {
            return TowerType.AsteriatedRuby;
        }

        else return TowerType.Unkown;

    }

    /// <summary>
    /// 输出输入物体的名字
    /// </summary>
    /// <param name="tt"></param>
    /// <returns></returns>
    public static string GetTowerName(TowerType tt)
    {
        switch (tt)
        {
            case TowerType.B1:
                return "蓝宝石1级";
            case TowerType.B2:
                return "蓝宝石2级";
            case TowerType.B3:
                return "蓝宝石3级";
            case TowerType.B4:
                return "蓝宝石4级";
            case TowerType.B5:
                return "蓝宝石5级";
            case TowerType.B6:
                return "蓝宝石6级";
            case TowerType.D1:
                return "钻石1级";
            case TowerType.D2:
                return "钻石2级";
            case TowerType.D3:
                return "钻石3级";
            case TowerType.D4:
                return "钻石4级";
            case TowerType.D5:
                return "钻石5级";
            case TowerType.D6:
                return "钻石6级";
            case TowerType.E1:
                return "蛋白石1级";
            case TowerType.E2:
                return "蛋白石2级";
            case TowerType.E3:
                return "蛋白石3级";
            case TowerType.E4:
                return "蛋白石4级";
            case TowerType.E5:
                return "蛋白石5级";
            case TowerType.E6:
                return "蛋白石6级";
            case TowerType.G1:
                return "绿宝石1级";
            case TowerType.G2:
                return "绿宝石2级";
            case TowerType.G3:
                return "绿宝石3级";
            case TowerType.G4:
                return "绿宝石4级";
            case TowerType.G5:
                return "绿宝石5级";
            case TowerType.G6:
                return "绿宝石6级";
            case TowerType.P1:
                return "紫宝石1级";
            case TowerType.P2:
                return "紫宝石2级";
            case TowerType.P3:
                return "紫宝石3级";
            case TowerType.P4:
                return "紫宝石4级";
            case TowerType.P5:
                return "紫宝石5级";
            case TowerType.P6:
                return "紫宝石6级";
            case TowerType.Q1:
                return "海晶石1级";
            case TowerType.Q2:
                return "海晶石2级";
            case TowerType.Q3:
                return "海晶石3级";
            case TowerType.Q4:
                return "海晶石4级";
            case TowerType.Q5:
                return "海晶石5级";
            case TowerType.Q6:
                return "海晶石6级";
            case TowerType.R1:
                return "蓝宝石1级";
            case TowerType.R2:
                return "蓝宝石2级";
            case TowerType.R3:
                return "蓝宝石3级";
            case TowerType.R4:
                return "蓝宝石4级";
            case TowerType.R5:
                return "蓝宝石5级";
            case TowerType.R6:
                return "蓝宝石6级";
            case TowerType.Y1:
                return "黄宝石1级";
            case TowerType.Y2:
                return "黄宝石2级";
            case TowerType.Y3:
                return "黄宝石3级";
            case TowerType.Y4:
                return "黄宝石4级";
            case TowerType.Y5:
                return "黄宝石5级";
            case TowerType.Y6:
                return "黄宝石6级";
            case TowerType.Sliver:
                return "白银";
            case TowerType.Malachite:
                return "孔雀石";
            case TowerType.AsteriatedRuby:
                return "星彩红宝石";
        }
        return "未知类型";
    }

}
