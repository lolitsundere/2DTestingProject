﻿using System.Collections;
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
        GreyJade, MonkeyKingJade, GullinanDiamond, ChineseJade, Lazurite, GoldenJubilee, Gold, EgyptGold,
        DarkEmerald, EmeraldGolem, ParaibaTourmaline, ElaboratelyCarvedTourmaline, SapphireStarOfAdam,
        DeepSeaPearl, ChrysoberylCatsEye, RedCoral, NaturalZumurud, CarmenLucia, YellowSapphire,
        NorthernSabersEye, StarSapphire, TheGreatStone
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
                tower.BasicPhysicalDamage = 2;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect60;
                tower.ProvideSpellImmunity = true;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减60移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.B2:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 4;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.B3:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 6;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect120;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减120移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.B4:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 8;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect150;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减150移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.B5:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 10;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect180;
                tower.TowerDescription = "防御塔特性:减少攻击目标的移动速度(减180移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.B6:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 36;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect480;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的移动速度(减480移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.D1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 5;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.D2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 10;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.D3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 20;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.D4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 40;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.D5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.D6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 460;
                tower.TowerDescription = "防御塔特性:\n高攻击";
                tower.AttackColor = Color.white;
                break;
            case TowerType.E1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 1;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect20);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加20)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.E2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 2;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect30);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加30)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.E3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 3;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect40);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加40)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.E4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 4;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect50);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加50)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.E5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 5;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect60);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加60)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.E6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 6;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect70);
                tower.CanBreakInvisibility = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加70)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.gray;
                break;
            case TowerType.G1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 2;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect1;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒1点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.G2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 4;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect2;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒2点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.G3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 6;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect4;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒4点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.G4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 8;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect8;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒8点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.G5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 10;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.G6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 12;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = Color.green;
                break;
            case TowerType.P1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 2;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect1;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减1点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.P2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 4;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect2;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减2点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.P3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 6;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect4;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减4点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.P4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 8;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect8;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减8点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.P5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 10;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect16;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减16点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.P6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 70;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x67, 0x4d, 0x8c, 0xff);
                break;
            case TowerType.Q1:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 2;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.Q2:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.9;
                tower.BasicPhysicalDamage = 4;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.Q3:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.8;
                tower.BasicPhysicalDamage = 8;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.Q4:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 16;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.Q5:
                tower.BasicAttackRange = 400;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 24;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.Q6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 300;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 80;
                tower.TowerDescription = "防御塔特性:\n高攻击速度";
                tower.AttackColor = new Color32(0x2b, 0x6d, 0xaa, 0xff);
                break;
            case TowerType.R1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 4;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect1;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3格内敌人受到主攻击目标所受30%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.R2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 8;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect2;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(3.5格内敌人受到主攻击目标所受40%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.R3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 12;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.R4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 24;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect4;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4.5格内敌人受到主攻击目标所受60%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.R5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 48;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect5;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(5格内敌人受到主攻击目标所受70%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.R6:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 150;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect6;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(7格内敌人受到主攻击目标所受100%的伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.Y1:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.BasicPhysicalDamage = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Y2:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.BasicPhysicalDamage = 6;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Y3:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.BasicPhysicalDamage = 9;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Y4:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.BasicPhysicalDamage = 18;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Y5:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.BasicPhysicalDamage = 36;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Y6:
                tower.BasicAttackRange = 5000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 200;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)\n全屏攻击";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.Sliver:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.9;
                tower.BasicPhysicalDamage = 25;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect90;
                tower.TowerDescription = "防御塔特性:\n高攻击\n减少攻击目标的移动速度(减90移动速度,持续2秒)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0xdb, 0xdb, 0xdb, 0xff);
                break;
            case TowerType.Malachite:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.8;
                tower.BasicPhysicalDamage = 15;
                tower.MaxTargetAmount = 3;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击3个目标)";
                tower.AttackColor = new Color32(0x1c, 0x8e, 0x77, 0xff);
                break;
            case TowerType.AsteriatedRuby:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 0;
                tower.BEffect = TowerController.BurnEffect.BurnEffect30; 
                tower.TowerDescription = "防御塔特性:\n灼烧攻击(5格内敌人每0.5秒受到30魔法伤害)";
                break;
            case TowerType.SliverKnight:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 60;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect120;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害\n减少攻击目标的移动速度(减120移动速度,持续2秒)\n同种效果不可叠加)";
                tower.AttackColor = new Color32(0xdb, 0xdb, 0xdb, 0xff);
                break;
            case TowerType.MalachiteHuge:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 50;
                tower.MaxTargetAmount = 5;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击5个目标)";
                tower.AttackColor = new Color32(0x1c, 0x8e, 0x77, 0xff);
                break;
            case TowerType.Jade:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 10;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect8;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒8点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x0b, 0x33, 0x0e, 0xff);
                break;
            case TowerType.Volcano:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 0;
                tower.BEffect = TowerController.BurnEffect.BurnEffect160;
                tower.TowerDescription = "防御塔特性:\n灼烧攻击(6格内敌人每0.5秒受到160魔法伤害)";
                break;
            case TowerType.PinkDiamond:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 100;
                tower.CanCrit = true;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)";
                tower.AttackColor = new Color32(0xc1, 0x6f, 0xb9, 0xff);
                break;
            case TowerType.PinkDiamondHuge:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 260;
                tower.CanCrit = true;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害)";
                tower.AttackColor = new Color32(0xc1, 0x6f, 0xb9, 0xff);
                break;
            case TowerType.KDiamond:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 1300;
                tower.CanCrit = true;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect3;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n分裂攻击(4格内敌人受到主攻击目标所受50%的伤害\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n同种效果不可叠加)";
                tower.AttackColor = Color.white;
                break;
            case TowerType.Uranium238:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 120;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)";
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.AttackColor = new Color32(0x3e, 0xcc, 0x2c, 0xff);
                break;
            case TowerType.Uranium235:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = 250;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)";
                tower.AttackColor = new Color32(0x3e, 0xcc, 0x2c, 0xff);
                break;
            case TowerType.DepletedKyparium:
                tower.BasicAttackRange = 5000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.4;
                tower.BasicPhysicalDamage = 410;
                tower.MaxTargetAmount = 10;
                tower.TowerDescription = "防御塔特性:\n多重攻击(可同时攻击10个目标)\n全屏攻击";
                tower.AttackColor = Color.black;
                break;
            case TowerType.BloodStone:
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 35;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 150;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成150魔法伤害,弹射5次)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.BloodStoneAntique:
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 70;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 3400;
                tower.BEffect = TowerController.BurnEffect.BurnEffect160;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成3400魔法伤害,弹射5次)\n灼烧攻击(6格内敌人每0.5秒受到160魔法伤害)";
                tower.AttackColor = Color.red;
                break;
            case TowerType.TheCrownPrince:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 70;
                tower.CanLightingChain = true;
                tower.LightingChainDamage = 3400;
                tower.BEffect = TowerController.BurnEffect.BurnEffect1250;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.TowerDescription = "防御塔特性:\n闪电链(攻击时有30%概率触发闪电链,对敌人造成3400魔法伤害,弹射5次)\n灼烧攻击(7格内敌人每0.5秒受到1250魔法伤害)\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0xf6, 0xce, 0x70, 0xff);
                break;
            case TowerType.Quartz:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 15;
                tower.AFlyEffect = TowerController.AntiFlyEffect.AntiFly1;
                tower.TowerDescription = "防御塔特性:\n飞行控制(使6格内的飞行敌人移动速度减少250,护甲减少10)\n同种效果不可叠加";
                tower.AttackColor = Color.white;
                break;
            case TowerType.GreyJade:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 30;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.ProvideAddRange = true;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n瞭望(增加3格周围3格内防御塔的攻击距离)\n同种效果不可叠加";
                tower.AttackColor = Color.grey;
                break;
            case TowerType.MonkeyKingJade:
                tower.BasicAttackRange = 1000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 80;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.ProvideAddRange = true;
                tower.ProvideCanNotMiss = true;
                tower.TowerDescription = "防御塔特性:\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n瞭望(增加3格周围3格内防御塔的攻击距离)\n必中(使周围3格内防御塔的攻击不会被闪避)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x97, 0xb0, 0xa1, 0xff);
                break;
            case TowerType.GullinanDiamond:
                tower.BasicAttackRange = 1000;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 3154;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.ProvideAddRange = true;
                tower.ProvideCanNotMiss = true;
                tower.CanCrit = true;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n瞭望(增加3格周围3格内防御塔的攻击距离)\n必中(使周围3格内防御塔的攻击不会被闪避)\n同种效果不可叠加";
                tower.AttackColor = Color.white;
                break;
            case TowerType.ChineseJade:
                tower.BasicAttackRange = 900;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 30;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect16;
                tower.CanHeal = true;
                tower.AFlyEffect = TowerController.AntiFlyEffect.AntiFly1;
                tower.TowerDescription = "防御塔特性:\n飞行控制(使6格内的飞行敌人移动速度减少250,护甲减少10)\n使攻击目标中毒(持续5秒,每秒16点魔法伤害)\n同种效果不可叠加\n回春(攻击有1%的几率回复基地1点生命)";
                tower.AttackColor = Color.green;
                break;
            case TowerType.Lazurite:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 30;
                tower.AFlyEffect = TowerController.AntiFlyEffect.AntiFly2;
                tower.TowerDescription = "防御塔特性:\n飞行控制(使6格内的飞行敌人移动速度减少250,护甲减少10,魔法抗性减少50%,无视魔法免疫)\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x19, 0x2f, 0x85, 0xff);
                break;
            case TowerType.GoldenJubilee:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.BasicPhysicalDamage = new System.Random().Next(1,1025);
                tower.AFlyEffect = TowerController.AntiFlyEffect.AntiFly2;
                tower.CanMagicSplash = true;
                tower.TowerDescription = "防御塔特性:\n随机攻击力(1-1024)\n魔法溅射(攻击时对目标周围2格内敌人造成等同于攻击力的魔法伤害)";
                tower.AttackColor = new Color32(0xd7, 0x64, 0x05, 0xff);
                break;
            case TowerType.Gold:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.8;
                tower.BasicPhysicalDamage = 60;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect20;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减20点护甲,持续2秒,无视魔法免疫)\n同种效果不可叠加)";
                tower.AttackColor = new Color32(0xff,0xd1,0x0c, 0xff);
                tower.transform.localScale = new Vector3(0.75f, 0.75f, 0.75f);
                break;
            case TowerType.EgyptGold:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.8;
                tower.BasicPhysicalDamage = 100;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect30;
                tower.ProvideGreedy = true;
                tower.TowerDescription = "防御塔特性:\n减少攻击目标的护甲值(减30点护甲,持续2秒,无视魔法免疫)\n贪婪(周围8格内防御塔在击杀敌人时有5%概率使击杀金钱x10)\n同种效果不可叠加)";
                tower.AttackColor = new Color32(0xff, 0xd1, 0x0c, 0xff);
                tower.transform.localScale = new Vector3(1f, 1f, 1f);
                break;
            case TowerType.DarkEmerald:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 80;
                tower.CanStun = true;
                tower.TowerDescription = "防御塔特性:\n重击(在攻击时有10%概率眩晕敌人2秒)";
                tower.AttackColor = new Color32(0x13, 0x45, 0x36, 0xff);
                break;
            case TowerType.EmeraldGolem:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.5;
                tower.BasicPhysicalDamage = 170;
                tower.CanStun = true;
                tower.CanStoneGaze = true;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect20;
                tower.TowerDescription = "防御塔特性:\n重击(在攻击时有10%概率眩晕敌人2秒\n减少攻击目标的护甲值(减20点护甲,持续2秒,无视魔法免疫)\n同种效果不可叠加\n在攻击时有2%概率使周围10格内敌人眩晕2秒)";
                tower.AttackColor = Color.green;
                break;
            case TowerType.ParaibaTourmaline:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 30;
                tower.ProvideArmorReduceAura15 = true;
                tower.TowerDescription = "防御塔特性:\n减少附近8格内敌人护甲15点\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x03, 0xf1, 0xfb, 0xff);
                break;
            case TowerType.ElaboratelyCarvedTourmaline:
                tower.BasicAttackRange = 700;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 130;
                tower.ProvideArmorReduceAura30 = true;
                tower.CanStun = true;
                tower.TowerDescription = "防御塔特性:\n重击(在攻击时有10%概率眩晕敌人2秒)\n减少附近12格内敌人护甲30点\n同种效果不可叠加";
                tower.AttackColor = new Color32(0x9b, 0x5a, 0x46, 0xff);
                break;
            case TowerType.SapphireStarOfAdam:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 42;
                tower.AtkPoisonEffect = TowerController.AttackPoisonEffect.PoisonEffect64;
                tower.AtkArmorReduceEffect = TowerController.AttackArmorReduceEffect.ArmorReduceEffect64;
                tower.ProvideArmorReduceAura30 = true;
                tower.CanFrozenAttack = true;
                tower.TowerDescription = "防御塔特性:\n减少附近12格内敌人护甲30点\n使攻击目标中毒(持续5秒,每秒64点魔法伤害)\n减少攻击目标的护甲值(减64点护甲,持续2秒)\n减少攻击目标以及周围3格内敌人一半的移速,持续3秒\n同种效果不可叠加";
                tower.AttackColor = Color.blue;
                break;
            case TowerType.DeepSeaPearl:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 80;
                tower.ProvideSpellImmunity = true;
                tower.TowerDescription = "防御塔特性:\n为周围6格内防御塔提供魔法免疫效果";
                tower.AttackColor = Color.white;
                break;
            case TowerType.ChrysoberylCatsEye:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 6;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect60);
                tower.CanBreakInvisibility = true;
                tower.ProvideInspire = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加50)\n增加临近5格内防御塔的攻击力(基础攻击力的50%)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.yellow;
                break;
            case TowerType.RedCoral:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.BasicPhysicalDamage = 120;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect60);
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect50);
                tower.CanBreakInvisibility = true;
                tower.ProvideInspire = true;
                tower.ProvideSpellImmunity = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加50+40)\n为周围6格内防御塔提供魔法免疫效果\n增加临近5格内防御塔的攻击力(基础攻击力的50%)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.red;
                break;
            case TowerType.NaturalZumurud:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 80;
                tower.ProvideSpellImmunity = true;
                WorldManager.TowerPerTurn++;
                tower.TowerDescription = "防御塔特性:\n为周围6格内防御塔提供魔法免疫效果\n每回合可以多造一个防御塔";
                tower.AttackColor = Color.black;
                break;
            case TowerType.CarmenLucia:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 6;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect70);
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect250);
                tower.CanBreakInvisibility = true;
                tower.ProvideInspire = true;
                tower.ProvideSpellImmunity = true;
                tower.TowerDescription = "防御塔特性:\n增加临近6格内防御塔的攻击速度(加70)\n增加临近1.5格内防御塔的攻击速度(加250)\n为周围6格内防御塔提供魔法免疫效果\n增加临近5格内防御塔的攻击力(基础攻击力的50%)\n同种效果不可叠加\n显示6格范围内的隐形敌人";
                tower.AttackColor = Color.red;
                break;
            case TowerType.YellowSapphire:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 20;
                tower.HasFrozenAura = true;
                tower.TowerDescription = "防御塔特性:\n减速光环(周围3格内敌人减速75%)";
                tower.AttackColor = new Color32(0xd0, 0xbd, 0x7e, 0xff);
                break;
            case TowerType.NorthernSabersEye:
                tower.BasicAttackRange = 500;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 60;
                tower.HasFrozenAura = true;
                tower.ProvideLightingChain = true;
                tower.TowerDescription = "防御塔特性:\n减速光环(周围3格内敌人减速75%)\n闪电链光环(周围2格防御塔攻击时有30%概率触发闪电链,对敌人造成500魔法伤害,弹射5次)";
                tower.AttackColor = new Color32(0x6a, 0x69, 0xab, 0xff);
                break;
            case TowerType.StarSapphire:
                tower.BasicAttackRange = 600;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 20;
                tower.HasFrozenAura = true;
                tower.ProvideLightingChain = true;
                tower.AccelerateEffectList.Add(TowerController.AttackSpeedAccelerateEffect.AccelerateEffect70);
                tower.CanBreakInvisibility = true;
                tower.AtkSlowEffect = TowerController.AttackSlowEffect.SlowEffect480;
                tower.TowerDescription = "防御塔特性:\n减速光环(周围3格内敌人减速75%)\n闪电链光环(周围2格防御塔攻击时有30%概率触发闪电链,对敌人造成500魔法伤害,弹射5次\n增加临近6格内防御塔的攻击速度(加70)\n减少攻击目标的移动速度(减480移动速度,持续2秒)\n同种效果不可叠加)";
                tower.AttackColor = new Color32(0x05, 0x06, 0x47, 0xff);
                break;
            case TowerType.TheGreatStone:
                tower.BasicAttackRange = 800;
                tower.BasicAttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.BasicPhysicalDamage = 2009;
                tower.CanCrit = true;
                tower.AtkSplashEffect = TowerController.AttackSplashEffect.SplashEffect6;
                tower.TowerDescription = "防御塔特性:\n暴击(10%概率打出5倍暴击)\n分裂攻击(7格内敌人受到主攻击目标所受100%的伤害)";
                tower.AttackColor = Color.gray;
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
        if (tower.name.StartsWith("EmeraldG"))
        {
            return TowerType.EmeraldGolem;
        }

        #region 紫宝石
        else if (tower.name.StartsWith("Ame"))
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
        else if (tower.name.StartsWith("Gullinan"))
        {
            return TowerType.GullinanDiamond;
        }
        else if (tower.name.StartsWith("Chinese"))
        {
            return TowerType.ChineseJade;
        }
        else if (tower.name.StartsWith("Lazurite"))
        {
            return TowerType.Lazurite;
        }
        else if (tower.name.StartsWith("Golden"))
        {
            return TowerType.GoldenJubilee;
        }
        else if (tower.name.StartsWith("Gold"))
        {
            if (tower.transform.localScale.x < 0.8f)
            {
                return TowerType.Gold;
            }
            else
            {
                return TowerType.EgyptGold;
            }
        }
        else if (tower.name.StartsWith("DarkEm"))
        {
            return TowerType.DarkEmerald;
        }
        else if (tower.name.StartsWith("ParaibaTour"))
        {
            return TowerType.ParaibaTourmaline;
        }
        else if (tower.name.StartsWith("ElaboratelyCar"))
        {
            return TowerType.ElaboratelyCarvedTourmaline;
        }
        else if (tower.name.StartsWith("DeepSeaPearl"))
        {
            return TowerType.DeepSeaPearl;
        }
        else if (tower.name.StartsWith("Chrysoberyl"))
        {
            return TowerType.ChrysoberylCatsEye;
        }
        else if (tower.name.StartsWith("RedC"))
        {
            return TowerType.RedCoral;
        }
        else if (tower.name.StartsWith("NaturalZumu"))
        {
            return TowerType.NaturalZumurud;
        }
        else if (tower.name.StartsWith("CarmenLu"))
        {
            return TowerType.CarmenLucia;
        }
        else if (tower.name.StartsWith("Yellow"))
        {
            return TowerType.YellowSapphire;
        }
        else if (tower.name.StartsWith("NorthernSaber"))
        {
            return TowerType.NorthernSabersEye;
        }
        else if (tower.name.StartsWith("Star"))
        {
            return TowerType.StarSapphire;
        }
        else if (tower.name.StartsWith("TheGr"))
        {
            return TowerType.TheGreatStone;
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
                return "翡翠1级";
            case TowerType.G2:
                return "翡翠2级";
            case TowerType.G3:
                return "翡翠3级";
            case TowerType.G4:
                return "翡翠4级";
            case TowerType.G5:
                return "翡翠5级";
            case TowerType.G6:
                return "翡翠6级";
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
            case TowerType.GullinanDiamond:
                return "卡利南钻石";
            case TowerType.ChineseJade:
                return "中国玉";
            case TowerType.Lazurite:
                return "青金石";
            case TowerType.GoldenJubilee:
                return "金色陛下";
            case TowerType.Gold:
                return "黄金";
            case TowerType.EgyptGold:
                return "埃及金";
            case TowerType.DarkEmerald:
                return "黑暗翡翠";
            case TowerType.EmeraldGolem:
                return "翡翠巨像";
            case TowerType.ParaibaTourmaline:
                return "帕拉伊巴碧玺";
            case TowerType.ElaboratelyCarvedTourmaline:
                return "精心雕琢的碧玺";
            case TowerType.SapphireStarOfAdam:
                return "斯里兰卡之星";
            case TowerType.DeepSeaPearl:
                return "深海珍珠";
            case TowerType.ChrysoberylCatsEye:
                return "猫眼石";
            case TowerType.RedCoral:
                return "红珊瑚";
            case TowerType.NaturalZumurud:
                return "天然祖母绿";
            case TowerType.CarmenLucia:
                return "卡门露西亚";
            case TowerType.YellowSapphire:
                return "黄彩蓝宝石";
            case TowerType.NorthernSabersEye:
                return "极地豹眼石";
            case TowerType.StarSapphire:
                return "星彩蓝宝石";
            case TowerType.TheGreatStone:
                return "镇家之石";
        }
        return "未知类型";
    }

    /// <summary>
    /// 输出输入物体的标签
    /// </summary>
    /// <param name="tt"></param>
    /// <returns></returns>
    public static string GetTowerTag(TowerType tt)
    {
        switch (tt)
        {
            case TowerType.B1:
                return "B1";
            case TowerType.B2:
                return "B2";
            case TowerType.B3:
                return "B3";
            case TowerType.B4:
                return "B4";
            case TowerType.B5:
                return "B5";
            case TowerType.B6:
                return "B6";
            case TowerType.D1:
                return "D1";
            case TowerType.D2:
                return "D2";
            case TowerType.D3:
                return "D3";
            case TowerType.D4:
                return "D4";
            case TowerType.D5:
                return "D5";
            case TowerType.D6:
                return "D6";
            case TowerType.E1:
                return "E1";
            case TowerType.E2:
                return "E2";
            case TowerType.E3:
                return "E3";
            case TowerType.E4:
                return "E4";
            case TowerType.E5:
                return "E5";
            case TowerType.E6:
                return "E6";
            case TowerType.G1:
                return "G1";
            case TowerType.G2:
                return "G2";
            case TowerType.G3:
                return "G3";
            case TowerType.G4:
                return "G4";
            case TowerType.G5:
                return "G5";
            case TowerType.G6:
                return "G6";
            case TowerType.P1:
                return "P1";
            case TowerType.P2:
                return "P2";
            case TowerType.P3:
                return "P3";
            case TowerType.P4:
                return "P4";
            case TowerType.P5:
                return "P5";
            case TowerType.P6:
                return "P6";
            case TowerType.Q1:
                return "Q1";
            case TowerType.Q2:
                return "Q2";
            case TowerType.Q3:
                return "Q3";
            case TowerType.Q4:
                return "Q4";
            case TowerType.Q5:
                return "Q5";
            case TowerType.Q6:
                return "Q6";
            case TowerType.R1:
                return "R1";
            case TowerType.R2:
                return "R2";
            case TowerType.R3:
                return "R3";
            case TowerType.R4:
                return "R4";
            case TowerType.R5:
                return "R5";
            case TowerType.R6:
                return "R6";
            case TowerType.Y1:
                return "Y1";
            case TowerType.Y2:
                return "Y2";
            case TowerType.Y3:
                return "Y3";
            case TowerType.Y4:
                return "Y4";
            case TowerType.Y5:
                return "Y5";
            case TowerType.Y6:
                return "Y6";
            case TowerType.Sliver:
                return "Sliver";
            case TowerType.Malachite:
                return "Malachite";
            case TowerType.AsteriatedRuby:
                return "AsteriatedRuby";
            case TowerType.SliverKnight:
                return "SliverKnight";
            case TowerType.MalachiteHuge:
                return "HugeMalachite";
            case TowerType.Jade:
                return "Jade";
            case TowerType.Volcano:
                return "Volcano";
            case TowerType.PinkDiamond:
                return "PinkDiamond";
            case TowerType.PinkDiamondHuge:
                return "HugePinkDiamond";
            case TowerType.Uranium235:
                return "Uranium235";
            case TowerType.Uranium238:
                return "Uranium238";
            case TowerType.BloodStone:
                return "Bloodstone";
            case TowerType.BloodStoneAntique:
                return "AntiqueBloodstone";
            case TowerType.Quartz:
                return "Quartz";
            case TowerType.GreyJade:
                return "GreyJade";
            case TowerType.MonkeyKingJade:
                return "MonkeyKingJade";;
            case TowerType.ChineseJade:
                return "ChineseJade";
            case TowerType.Lazurite:
                return "Lazurite";
            case TowerType.Gold:
                return "Gold";
            case TowerType.DarkEmerald:
                return "DarkEmerald";
            case TowerType.ParaibaTourmaline:
                return "ParaibaTourmaline";
            case TowerType.ElaboratelyCarvedTourmaline:
                return "ElaboratelyCarvedTourmaline";
            case TowerType.DeepSeaPearl:
                return "DeepSeaPearl";
            case TowerType.ChrysoberylCatsEye:
                return "ChrysoberylCatsEye";
            case TowerType.RedCoral:
                return "RedCoral";
            case TowerType.YellowSapphire:
                return "YellowSapphire";
            case TowerType.NorthernSabersEye:
                return "NorthernSabersEye";


        }
        return "Untagged";
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
            case TowerType.GullinanDiamond:
                return "GullinanDiamond";
            case TowerType.ChineseJade:
                return "ChineseJade";
            case TowerType.Lazurite:
                return "Lazurite";
            case TowerType.GoldenJubilee:
                return "GoldenJubilee";
            case TowerType.Gold:
                return "Gold";
            case TowerType.EgyptGold:
                return "Gold";
            case TowerType.DarkEmerald:
                return "DarkEmerald";
            case TowerType.EmeraldGolem:
                return "EmeraldGolem";
            case TowerType.ParaibaTourmaline:
                return "ParaibaTourmaline";
            case TowerType.ElaboratelyCarvedTourmaline:
                return "ElaboratelyCarvedTourmaline";
            case TowerType.SapphireStarOfAdam:
                return "SapphireStarOfAdam";
            case TowerType.DeepSeaPearl:
                return "DeepSeaPearl";
            case TowerType.ChrysoberylCatsEye:
                return "ChrysoberylCatsEye";
            case TowerType.RedCoral:
                return "RedCoral";
            case TowerType.NaturalZumurud:
                return "NaturalZumurud";
            case TowerType.CarmenLucia:
                return "CarmenLucia";
            case TowerType.YellowSapphire:
                return "YellowSapphire";
            case TowerType.NorthernSabersEye:
                return "NorthernSabersEye";
            case TowerType.StarSapphire:
                return "StarSapphire";
            case TowerType.TheGreatStone:
                return "TheGreatStone";
        }
        return "";
    }

}
