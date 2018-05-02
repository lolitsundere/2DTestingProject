using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TowerManager : MonoBehaviour
{
    public enum TowerType
    {
        Unkown, R1, R2, R3, R4, R5, R6, B1, B2, B3, B4, B5, B6, Y1, Y2, Y3, Y4, Y5, Y6, G1, G2, G3, G4, G5, G6,
        P1, P2, P3, P4, P5, P6, Q1, Q2, Q3, Q4, Q5, Q6, D1, D2, D3, D4, D5, D6, E1, E2, E3, E4, E5, E6,
        Sliver, Malachite, AsteriatedRuby, SliverKnight, MalachiteHuge, Jade, Volcano, PinkDiamond, PinkDiamondHuge,
        KDiamond, Uranium238, Uranium235, DepletedKyparium, BloodStone, BloodStoneAntique, TheCrownPrince, Quartz,
        GreyJade, MonkeyKingJade
    };

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
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect60;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减60移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B2:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B3:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect120;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减120移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B4:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect150;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减150移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B5:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect180;
                tower.TowerDescription = "防御塔特性:减少攻击目标的移动速度(减180移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.B6:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 36;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect480;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减480移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.D1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 20;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 40;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.D6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 460;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                break;
            case TowerType.E1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 1;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect20;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加20)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect30;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加30)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 3;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect40;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加40)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect50;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加50)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect60;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加60)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.E6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AccelerateEffect = TowerController.AttackSpeedAccelerateEffect.AccelerateEffect70;
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加70)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                break;
            case TowerType.G1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect1;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒1点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect2;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒2点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect4;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒4点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect8;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒8点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.G6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.P1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 2;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect1;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减1点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 4;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect2;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减2点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 6;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect4;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减4点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 8;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect8;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减8点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 10;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect16;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减16点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.P6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 70;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.Q1:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q2:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.9;
                tower.PhysicalDamage = 4;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q3:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.8;
                tower.PhysicalDamage = 8;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q4:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 16;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q5:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 24;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.Q6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                break;
            case TowerType.R1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect1;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3格内敌人受到主攻击目标所受30%的伤害)";
                break;
            case TowerType.R2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect2;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3.5格内敌人受到主攻击目标所受40%的伤害)";
                break;
            case TowerType.R3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害)";
                break;
            case TowerType.R4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 24;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect4;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4.5格内敌人受到主攻击目标所受60%的伤害)";
                break;
            case TowerType.R5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 48;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect5;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(5格内敌人受到主攻击目标所受70%的伤害)";
                break;
            case TowerType.R6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 150;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect6;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(7格内敌人受到主攻击目标所受100%的伤害)";
                break;
            case TowerType.Y1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 6;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 9;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 18;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 36;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.Y6:
                tower.BasicAttackRange = 5000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 200;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)\n全屏攻击";
                break;
            case TowerType.Sliver:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.9;
                tower.PhysicalDamage = 25;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n高攻击\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                break;
            case TowerType.Malachite:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.8;
                tower.PhysicalDamage = 15;
                tower.MaxTargetAmount = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                break;
            case TowerType.AsteriatedRuby:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 0;
                tower.BEffect = TowerController.BurnEffect.BurnEffect30; 
                tower.TowerDescription = "防御塔特性:\n灼烧攻击(5格内敌人每0.5秒受到30魔法伤害)";
                break;
            case TowerType.SliverKnight:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 60;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect120;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害\n减少攻击目标的移动速度(减120移动速度,持续2秒)\n同种效果不可叠加)";
                break;
            case TowerType.MalachiteHuge:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 50;
                tower.MaxTargetAmount = 5;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击5个目标)";
                break;
            case TowerType.Jade:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 10;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect8;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒8点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.Volcano:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 0;
                tower.BEffect = TowerController.BurnEffect.BurnEffect160;
                tower.TowerDescription = "防御塔特性:\n灼烧攻击(6格内敌人每0.5秒受到160魔法伤害)";
                break;
            case TowerType.PinkDiamond:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 100;
                tower.CanCrit = true;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)";
                break;
            case TowerType.PinkDiamondHuge:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 260;
                tower.CanCrit = true;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害)";
                break;
            case TowerType.KDiamond:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 1300;
                tower.CanCrit = true;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n同种效果不可叠加)";
                break;
            case TowerType.Uranium238:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 120;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)";
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                break;
            case TowerType.Uranium235:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 250;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)";
                break;
            case TowerType.DepletedKyparium:
                tower.BasicAttackRange = 5000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.4;
                tower.PhysicalDamage = 410;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)\n全屏攻击";
                break;
            case TowerType.BloodStone:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 35;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 150;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成150魔法伤害,弹射5次)";
                break;
            case TowerType.BloodStoneAntique:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 70;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 3400;
                tower.BEffect = TowerController.BurnEffect.BurnEffect160;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成3400魔法伤害,弹射5次)\n灼烧攻击(6格内敌人每0.5秒受到160魔法伤害)";
                break;
            case TowerType.TheCrownPrince:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 70;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 3400;
                tower.BEffect = TowerController.BurnEffect.BurnEffect1250;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成3400魔法伤害,弹射5次)\n灼烧攻击(7格内敌人每0.5秒受到1250魔法伤害)\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n同种效果不可叠加";
                break;
            case TowerType.Quartz:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 15;
                tower.AFlyEffect = TowerController.AntiFlyEffect.AntiFly1;
                tower.TowerDescription = "防御塔特性:\n飞行控制(使6格内的飞行敌人移动速度减少250,护甲减少10)\n同种效果不可叠加";
                break;
            case TowerType.GreyJade:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 30;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.CanAddRange = true;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n瞭望(增加3格周围3格内防御塔的攻击距离)\n同种效果不可叠加";
                break;
            case TowerType.MonkeyKingJade:
                tower.BasicAttackRange = 1000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 80;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.CanAddRange = true;
                tower.ProvideCanNotMiss = true;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n瞭望(增加3格周围3格内防御塔的攻击距离)\n必中(使周围3格内防御塔的攻击不会被闪避)\n同种效果不可叠加";
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
                return TowerType.SliverKnight;
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
                return TowerType.MalachiteHuge;
            }
        }

        else if (tower.name.StartsWith("Aster"))
        {
            return TowerType.AsteriatedRuby;
        }

        else if (tower.name.StartsWith("Jade"))
        {
            return TowerType.Jade;
        }

        else if (tower.name.StartsWith("Vol"))
        {
            return TowerType.Volcano;
        }

        else if (tower.name.StartsWith("Pink"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.PinkDiamond;
            }
            else
            {
                return TowerType.PinkDiamondHuge;
            }
        }
        else if (tower.name.StartsWith("Koh"))
        {
            return TowerType.KDiamond;
        }
        else if (tower.name.StartsWith("Uranium"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.Uranium238;
            }
            else
            {
                return TowerType.Uranium235;
            }
        }
        else if (tower.name.StartsWith("Depleted"))
        {
            return TowerType.DepletedKyparium;
        }
        else if (tower.name.StartsWith("Blood"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.BloodStone;
            }
            else
            {
                return TowerType.BloodStoneAntique;
            }
        }
        else if (tower.name.StartsWith("TheCrown"))
        {
            return TowerType.TheCrownPrince;
        }
        else if (tower.name.StartsWith("Quartz"))
        {
            return TowerType.Quartz;
        }
        else if (tower.name.StartsWith("GreyJade"))
        {
            return TowerType.GreyJade;
        }
        else if (tower.name.StartsWith("MonkeyKingJade"))
        {
            return TowerType.MonkeyKingJade;
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
                return "红宝石1级";
            case TowerType.R2:
                return "红宝石2级";
            case TowerType.R3:
                return "红宝石3级";
            case TowerType.R4:
                return "红宝石4级";
            case TowerType.R5:
                return "红宝石5级";
            case TowerType.R6:
                return "红宝石6级";
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
            case TowerType.SliverKnight:
                return "白银骑士";
            case TowerType.MalachiteHuge:
                return "巨大孔雀石";
            case TowerType.Jade:
                return "玉";
            case TowerType.Volcano:
                return "火山";
            case TowerType.PinkDiamond:
                return "粉红钻石";
            case TowerType.PinkDiamondHuge:
                return "巨大粉红钻石";
            case TowerType.KDiamond:
                return "光之山";
            case TowerType.Uranium235:
                return "铀235";
            case TowerType.Uranium238:
                return "铀238";
            case TowerType.DepletedKyparium:
                return "衰变凯帕铀";
            case TowerType.BloodStone:
                return "鸡血石";
            case TowerType.BloodStoneAntique:
                return "远古鸡血石";
            case TowerType.TheCrownPrince:
                return "黑王子红宝石";
            case TowerType.Quartz:
                return "石英";
            case TowerType.GreyJade:
                return "青玉";
            case TowerType.MonkeyKingJade:
                return "猴王玉";
        }
        return "未知类型";
    }

    /// <summary>
    /// 输出输入物体的文件名
    /// </summary>
    /// <param name="tt"></param>
    /// <returns></returns>
    public static string GetTowerFileName(TowerType tt)
    {
        switch (tt)
        {
            case TowerType.AsteriatedRuby:
                return "AsteriatedRuby";
            case TowerType.Malachite:
                return "Malachite";
            case TowerType.Sliver:
                return "Sliver";
            case TowerType.SliverKnight:
                return "Sliver";
            case TowerType.MalachiteHuge:
                return "Malachite";
            case TowerType.Jade:
                return "Jade";
            case TowerType.Volcano:
                return "Volcano";
            case TowerType.PinkDiamond:
                return "PinkDiamond";
            case TowerType.PinkDiamondHuge:
                return "PinkDiamond";
            case TowerType.KDiamond:
                return "Koh-i-noorDiamond";
            case TowerType.Uranium235:
                return "Uranium";
            case TowerType.Uranium238:
                return "Uranium";
            case TowerType.DepletedKyparium:
                return "DepletedKyparium";
            case TowerType.BloodStone:
                return "BloodStone";
            case TowerType.BloodStoneAntique:
                return "BooldStone";
            case TowerType.TheCrownPrince:
                return "TheCrownPrince";
            case TowerType.Quartz:
                return "Quartz";
            case TowerType.GreyJade:
                return "GreyJade";
            case TowerType.MonkeyKingJade:
                return "MonkeyKingJade";
        }

        return "";
    }

}
