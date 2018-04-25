using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public enum DamageType {Physical, Magic, Pure};
    public enum AttackSlowEffect { SlowEffect0, SlowEffect60, SlowEffect90, SlowEffect120, SlowEffect150, SlowEffect180, SlowEffect480};
    public enum AttackSpeedAccelerateEffect { AccelerateEffect0, AccelerateEffect20, AccelerateEffect30, AccelerateEffect40, AccelerateEffect50, AccelerateEffect60, AccelerateEffect70 };


    private double attackSpeed;
    public double AttackSpeed
    {
        get
        {
            return attackSpeed;
        }

        set
        {
            attackSpeed = value;
            if (basicAttackTime > 0)
            {
                attackTime = basicAttackTime / (attackSpeed * 0.01);
            }
        }
    }

    private double basicAttackTime;
    public double BasicAttackTime
    {
        get
        {
            return basicAttackTime;
        }

        set
        {
            basicAttackTime = value;
            if (AttackSpeed > 0)
            {
                attackTime = basicAttackTime / (attackSpeed * 0.01);
            }
        }
    }

    public int PhysicalDamage;

    private int attackRange;
    public int AttackRange
    {
        get
        {
            return attackRange;
        }
        set
        {
            if (attackRange != value)
            {
                Object o = null;
                switch (value)
                {
                    case 400:
                        o = Instantiate(Resources.Load("AttackRange400"), transform);
                        break;
                    case 500:
                        o = Instantiate(Resources.Load("AttackRange500"), transform);
                        break;
                    case 600:
                        o = Instantiate(Resources.Load("AttackRange600"), transform);
                        break;
                }

                if (o != null && o is GameObject)
                {
                    GameObject go = o as GameObject;
                    go.GetComponent<ColliderEventHandler>().EnemyEnterEvent += EnemyIn;
                    go.GetComponent<ColliderEventHandler>().EnemyExitEvent += EnemyExit;
                    go.GetComponent<ColliderEventHandler>().EnemyStayEvent += EnemyIn;
                }
            }
            attackRange = value;
        }
    }
    public int MaxTargetAmount;

    public AttackSlowEffect attackSlowEffect;
    public AttackSpeedAccelerateEffect attackSpeedAccelerateEffect;

    private List<GameObject> AttackTargets;
    private float time;
    private double attackTime;

    
    private void PhysicalAttack()
    {
        foreach (GameObject go in AttackTargets)
        {
            go.GetComponent<EnemyController>().TakeTowerAttack(this);
        }
    }

    private void EnemyIn(GameObject enemy)
    {
        if (MaxTargetAmount > AttackTargets.Count && !AttackTargets.Contains(enemy))
        {
            AttackTargets.Add(enemy);
        }
    }

    private void EnemyExit(GameObject enemy)
    {
        if (AttackTargets.Contains(enemy))
        {
            AttackTargets.Remove(enemy);
        }
    }



    private void Start()
    {
        AttackTargets = new List<GameObject>();
        time = 0;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if (attackTime != 0 && time > attackTime)
        {
            PhysicalAttack();
            time = 0;
        }
    }


}
