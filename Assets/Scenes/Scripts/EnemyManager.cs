using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    /// <summary>
    /// 根据当前关数给敌人赋值
    /// </summary>
    /// <param name="enemy"></param>
    /// <param name="level"></param>
    public static void SetEnemy(EnemyController enemy, int level, int playerFactor)
    {
        float hpFactor=0;
        float movementSpeedFactor =0;
        switch (playerFactor)
        {
            case 1:
                hpFactor = 0.6f;
                movementSpeedFactor = 0.85f;
                break;
            case 2:
                hpFactor = 2f;
                movementSpeedFactor = 1.15f;
                break;
            case 3:
                hpFactor = 4.2f;
                movementSpeedFactor = 1.36f;
                break;
            case 4:
                hpFactor = 5.6f;
                movementSpeedFactor = 1.58f;
                break;

        }
        switch (level)
        {
            case 1:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(6 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(525 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 5;
                break;
            case 2:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(10 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 5;
                break;
            case 3:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(20 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(525 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 5;
                break;
            case 4:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(20 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(1000 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 6;
                break;
            case 5:
                if (UnityEngine.Random.value < 0.5)
                {
                    enemy.MaxHealth = Convert.ToInt32(Mathf.Round(24 * hpFactor));
                }
                else
                {
                    enemy.MaxHealth = Convert.ToInt32(Mathf.Round(22 * hpFactor));
                }
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(500 * movementSpeedFactor));
                enemy.IsFlying = true;
                enemy.EnemyDescription = "敌人特性:\n飞行(无视地形移动)";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 6;
                break;
            case 6:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(100 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(450 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 6;
                break;
            case 7:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(100 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 7;
                break;
            case 8:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(70 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(750 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n隐形";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 7;
                enemy.IsInvisible = true;
                break;
            case 9:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(120 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n闪避(50%)";
                enemy.ExperienceAndGold = 5;
                enemy.MaxAmount = 7;
                enemy.Evation = 0.5f;
                break;
            case 10:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(2100 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(750 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n普通BOSS";
                enemy.ExperienceAndGold = 300;
                enemy.MaxAmount = 1;
                enemy.MaxDamageToPlayer = 100;
                break;
            case 11:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(300 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(525 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 8;
                break;
            case 12:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(450 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.2f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n缴械(1.2格内防御塔无法攻击)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 8;
                enemy.Disarmble = true;
                break;
            case 13:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(800 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n无)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 9;
                break;
            case 14:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(1100 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n折射(在受到伤害时有15%概率生成3层防护罩)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 9;
                enemy.Refractable = true;
                break;
            case 15:
                if (UnityEngine.Random.value < 0.5)
                {
                    enemy.MaxHealth = Convert.ToInt32(Mathf.Round(400 * hpFactor));
                    enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(700 * movementSpeedFactor));
                }
                else
                {
                    enemy.MaxHealth = Convert.ToInt32(Mathf.Round(440 * hpFactor));
                    enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                }
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.IsFlying = true;
                enemy.EnemyDescription = "敌人特性:\n飞行(无视地形移动)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 9;
                break;
            case 16:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(950 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(800 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n魔法免疫(无视魔法伤害,无视控制)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 10;
                enemy.SpellImmunity = true;
                break;
            case 17:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(1600 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.5f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(600 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n不可侵犯(-300攻击它的防御塔的攻速)";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 10;
                enemy.Untouchable = true;
                break;
            case 18:
                enemy.MaxHealth = Convert.ToInt32(Mathf.Round(3000 * hpFactor));
                enemy.Health = enemy.MaxHealth;
                enemy.Armor = 4;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = Convert.ToInt32(Mathf.Round(675 * movementSpeedFactor));
                enemy.EnemyDescription = "敌人特性:\n隐形+缴械";
                enemy.ExperienceAndGold = 10;
                enemy.MaxAmount = 10;
                enemy.IsInvisible = true;
                enemy.Disarmble = true;
                break;

        }
    }

    public static String GetEenemyInfo(int level)
    {
        switch (level)
        {
            case 5:
                return "下拨敌人: 飞行敌人(可无视地形移动)";
            case 8:
                return "下拨敌人: 隐身敌人(需蛋白石类防御塔反隐后才可攻击)";
            case 9:
                return "下拨敌人: 闪避敌人(有概率闪避攻击)";
            case 10:
                return "下拨敌人: 普通BOSS";
            case 12:
                return "下拨敌人: 缴械敌人(使周围防御塔无法攻击)";
            case 14:
                return "下拨敌人: 折射敌人(在受到伤害时有概率生成防护罩抵御伤害)";
            default:
                return "下拨敌人: 普通敌人";
        }
    }

}
