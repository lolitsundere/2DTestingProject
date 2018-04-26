using System;
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

    public double BasicAttackSpeed
    {
        set
        {
            accelerate20 = 0;
            accelerate30 = 0;
            accelerate40 = 0;
            accelerate50 = 0;
            accelerate60 = 0;
            accelerate70 = 0;
            AttackSpeed = value;
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
                UnityEngine.Object o = null;
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
    public AttackSpeedAccelerateEffect AccelerateEffect;

    private List<GameObject> AttackTargets;
    private float time;
    public double attackTime;

    private double accelerate20;
    private double accelerate30;
    private double accelerate40;
    private double accelerate50;
    private double accelerate60;
    private double accelerate70;
    
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

        CheckTowerAroundForAcceleration();
        CheckAccelerateState();
    }

    private void CheckTowerAroundForAcceleration()
    {
        if (AccelerateEffect != AttackSpeedAccelerateEffect.AccelerateEffect0)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask("Tower")))
            {
                switch (AccelerateEffect)
                {
                    case AttackSpeedAccelerateEffect.AccelerateEffect20:
                        if (go1.GetComponent<TowerController>().accelerate20 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 20;
                        }
                        go1.GetComponent<TowerController>().accelerate20 = 0.5;
                        break;
                    case AttackSpeedAccelerateEffect.AccelerateEffect30:
                        if (go1.GetComponent<TowerController>().accelerate30 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 30;
                        }
                        go1.GetComponent<TowerController>().accelerate30 = 0.5;
                        break;
                    case AttackSpeedAccelerateEffect.AccelerateEffect40:
                        if (go1.GetComponent<TowerController>().accelerate40 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 40;
                        }
                        go1.GetComponent<TowerController>().accelerate40 = 0.5;
                        break;
                    case AttackSpeedAccelerateEffect.AccelerateEffect50:
                        if (go1.GetComponent<TowerController>().accelerate50 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 50;
                        }
                        go1.GetComponent<TowerController>().accelerate50 = 0.5; ;
                        break;
                    case AttackSpeedAccelerateEffect.AccelerateEffect60:
                        if (go1.GetComponent<TowerController>().accelerate60 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 60;
                        }
                        go1.GetComponent<TowerController>().accelerate60 = 0.5;
                        break;
                    case AttackSpeedAccelerateEffect.AccelerateEffect70:
                        if (go1.GetComponent<TowerController>().accelerate70 == 0)
                        {
                            go1.GetComponent<TowerController>().AttackSpeed += 70;
                        }
                        go1.GetComponent<TowerController>().accelerate70 = 0.5;
                        break;

                }
            }
        }
    }

    private void CheckAccelerateState()
    {

        if (accelerate20 > 0)
        {
            accelerate20 -= Time.deltaTime;
            if (accelerate20 <= 0)
            {
                accelerate20 = 0;
                AttackSpeed -= 20;
            }
        }

        if (accelerate30 > 0)
        {
            accelerate30 -= Time.deltaTime;
            if (accelerate30 <= 0)
            {
                accelerate30 = 0;
                AttackSpeed -= 30;
            }
        }

        if (accelerate40 > 0)
        {
            accelerate40 -= Time.deltaTime;
            if (accelerate40 <= 0)
            {
                accelerate40 = 0;
                AttackSpeed -= 40;
            }
        }

        if (accelerate50 > 0)
        {
            accelerate50 -= Time.deltaTime;
            if (accelerate50 <= 0)
            {
                accelerate50 = 0;
                AttackSpeed -= 50;
            }
        }


        if (accelerate60 > 0)
        {
            accelerate60 -= Time.deltaTime;
            if (accelerate60 <= 0)
            {
                accelerate60 = 0;
                AttackSpeed -= 60;
            }
        }


        if (accelerate70 > 0)
        {
            accelerate20 -= Time.deltaTime;
            if (accelerate70 <= 0)
            {
                accelerate70 = 0;
                AttackSpeed -= 70;
            }
        }
    }
}
