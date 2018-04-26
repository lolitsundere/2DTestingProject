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
    public static void SetEnemy(EnemyController enemy, int level)
    {
        switch (level)
        {
            case 1:
                enemy.MaxHealth = 3;
                enemy.Health = 3;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = 446;
                break;
            case 2:
                enemy.MaxHealth = 6;
                enemy.Health = 6;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = 510;
                break;
            case 3:
                enemy.MaxHealth = 12;
                enemy.Health = 12;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = 446;
                break;
            case 4:
                enemy.MaxHealth = 12;
                enemy.Health = 12;
                enemy.Armor = 0;
                enemy.MagicResistance = 0.1f;
                enemy.MovementSpeed = 850;
                break;

        }
    }

}
