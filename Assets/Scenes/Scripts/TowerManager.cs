using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerManager : MonoBehaviour
{
    public static void SettingTower(TowerController tower,TowerCombiningManager.TowerType tt)
    {
        switch (tt)
        {
            case TowerCombiningManager.TowerType.B1:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                break;
            case TowerCombiningManager.TowerType.B2:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.B3:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                break;
            case TowerCombiningManager.TowerType.D1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                break;
            case TowerCombiningManager.TowerType.D2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                break;
            case TowerCombiningManager.TowerType.D3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 20;
                break;
            case TowerCombiningManager.TowerType.E1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 1;
                break;
            case TowerCombiningManager.TowerType.E2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                break;
            case TowerCombiningManager.TowerType.E3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 3;
                break;
            case TowerCombiningManager.TowerType.G1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                break;
            case TowerCombiningManager.TowerType.G2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.G3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                break;
            case TowerCombiningManager.TowerType.P1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 2;
                break;
            case TowerCombiningManager.TowerType.P2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.P3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 6;
                break;
            case TowerCombiningManager.TowerType.Q1:
                tower.AttackRange = 400;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 2;
                break;
            case TowerCombiningManager.TowerType.Q2:
                tower.AttackRange = 400;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 0.9;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.Q3:
                tower.AttackRange = 400;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 0.8;
                tower.PhysicalDamage = 8;
                break;
            case TowerCombiningManager.TowerType.R1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.R2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                break;
            case TowerCombiningManager.TowerType.R3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                break;
            case TowerCombiningManager.TowerType.Y1:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 3;
                break;
            case TowerCombiningManager.TowerType.Y2:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 6;
                break;
            case TowerCombiningManager.TowerType.Y3:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 9;
                break;
            case TowerCombiningManager.TowerType.B4:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                break;
            case TowerCombiningManager.TowerType.B5:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                break;
            case TowerCombiningManager.TowerType.B6:
                tower.AttackRange = 600;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 36;
                break;
            case TowerCombiningManager.TowerType.D4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 40;
                break;
            case TowerCombiningManager.TowerType.D5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 80;
                break;
            case TowerCombiningManager.TowerType.D6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 460;
                break;
            case TowerCombiningManager.TowerType.E4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 4;
                break;
            case TowerCombiningManager.TowerType.E5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 5;
                break;
            case TowerCombiningManager.TowerType.E6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 6;
                break;
            case TowerCombiningManager.TowerType.G4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 8;
                break;
            case TowerCombiningManager.TowerType.G5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 10;
                break;
            case TowerCombiningManager.TowerType.G6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 12;
                break;
            case TowerCombiningManager.TowerType.P4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 8;
                break;
            case TowerCombiningManager.TowerType.P5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 10;
                break;
            case TowerCombiningManager.TowerType.P6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 70;
                break;
            case TowerCombiningManager.TowerType.Q4:
                tower.AttackRange = 400;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 0.7;
                tower.PhysicalDamage = 16;
                break;
            case TowerCombiningManager.TowerType.Q5:
                tower.AttackRange = 400;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 24;
                break;
            case TowerCombiningManager.TowerType.Q6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 300;
                tower.BasicAttackTime = 0.5;
                tower.PhysicalDamage = 80;
                break;
            case TowerCombiningManager.TowerType.R4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 24;
                break;
            case TowerCombiningManager.TowerType.R5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 48;
                break;
            case TowerCombiningManager.TowerType.R6:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1;
                tower.PhysicalDamage = 150;
                break;
            case TowerCombiningManager.TowerType.Y4:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 18;
                break;
            case TowerCombiningManager.TowerType.Y6:
                tower.AttackRange = 5000;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 0.6;
                tower.PhysicalDamage = 200;
                break;
            case TowerCombiningManager.TowerType.Y5:
                tower.AttackRange = 500;
                tower.AttackSpeed = 100;
                tower.BasicAttackTime = 1.3;
                tower.PhysicalDamage = 36;
                break;
        }
    }

}
