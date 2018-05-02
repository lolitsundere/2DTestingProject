﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerController : MonoBehaviour
{
    public enum AttackSlowEffect { SlowEffect0, SlowEffect60, SlowEffect90, SlowEffect120, SlowEffect150, SlowEffect180, SlowEffect480};
    public enum AttackSpeedAccelerateEffect { AccelerateEffect0, AccelerateEffect20, AccelerateEffect30, AccelerateEffect40, AccelerateEffect50, AccelerateEffect60, AccelerateEffect70 };
    public enum AttackPoisonEffect { PoisonEffect0, PoisonEffect1, PoisonEffect2, PoisonEffect4, PoisonEffect8, PoisonEffect16, PoisonEffect64};
    public enum AttackArmorReduceEffect { ArmorReduceEffect0, ArmorReduceEffect1, ArmorReduceEffect2, ArmorReduceEffect4, ArmorReduceEffect8, ArmorReduceEffect16, ArmorReduceEffect64 };
    public enum AttackSplashEffect { SplashEffect0 , SplashEffect1, SplashEffect2, SplashEffect3,SplashEffect4,SplashEffect5, SplashEffect6};
    public enum BurnEffect { BurnEffect0, BurnEffect30, BurnEffect160, BurnEffect1250};
    public enum AntiFlyEffect { AnitFly0, AntiFly1}


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
        get { return attackRange; }
        set
        {
            if (value > 5000)
            {
                value = 5000;
            }
            if (attackRange != value)
            {
                if (transform.childCount > 0)
                {
                    Destroy(transform.GetChild(0).gameObject);
                }
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
                    case 700:
                        o = Instantiate(Resources.Load("AttackRange700"), transform);
                        break;
                    case 800:
                        o = Instantiate(Resources.Load("AttackRange800"), transform);
                        break;
                    case 900:
                        o = Instantiate(Resources.Load("AttackRange900"), transform);
                        break;
                    case 1000:
                        o = Instantiate(Resources.Load("AttackRange1000"), transform);
                        break;
                    case 1100:
                        o = Instantiate(Resources.Load("AttackRange1100"), transform);
                        break;
                    case 5000:
                        o = Instantiate(Resources.Load("AttackRange5000"), transform);
                        break;
                }
            }
            transform.GetChild(transform.childCount - 1).transform.localScale = new Vector3(1f / transform.localScale.x, 1f / transform.localScale.y, 1f / transform.localScale.z);
            attackRange = value;
        }
    }
    public int BasicAttackRange
    {
        get
        {
            return attackRange;
        }
        set
        {
            addRange300 = 0;
            AttackRange = value;
        }
    }

    public int MaxTargetAmount;

    public bool CanBreakInvisibility;
    public bool CanCrit;
    public bool CanLightingChain;
    public bool CanAddRange;
    public bool ProvideCanNotMiss;
    public bool CanNotMiss;
    private double canNotMissTimer;
    public int LightingChainDamage;
    public String TowerDescription;

    public AttackSlowEffect AtkSlowEffect;
    public AttackPoisonEffect AtkPoisonEffect;
    public AttackSpeedAccelerateEffect AccelerateEffect;
    public AttackArmorReduceEffect AtkArmorReduceEffect;
    public AttackSplashEffect AtkSplashEffect;
    public BurnEffect BEffect;
    public AntiFlyEffect AFlyEffect;

    public float attackTimer;
    public double attackTime;

    private float burnTimer;

    private double accelerate20;
    private double accelerate30;
    private double accelerate40;
    private double accelerate50;
    private double accelerate60;
    private double accelerate70;

    private double addRange300;
    
    private void PhysicalAttack()
    {
        var targets = Physics2D.OverlapCircleAll(transform.position, BasicAttackRange / 100f, LayerMask.GetMask("Enemy"));
        
        if (targets.Length == 0)
        {
            return;
        }
        else if (targets.Length <= MaxTargetAmount)
        {
            foreach (Collider2D target in targets)
            {
                target.GetComponent<EnemyController>().TakeTowerAttack(this);
            }
        }
        else
        {
            foreach (int i in Enumerable.Range(0,MaxTargetAmount))
            {
                targets[i].GetComponent<EnemyController>().TakeTowerAttack(this);
            }
        }
        attackTimer = 0;
    }

    private void Start()
    {
        attackTimer = 0;
        burnTimer = 0;
    }

    private void Update()
    {
        attackTimer += Time.deltaTime;
        if (attackTime != 0 && attackTimer > attackTime)
        {
            PhysicalAttack();
        }

        CheckTowerAroundForAcceleration();
        CheckAccelerateState();
        CheckBurnAttack();
        CheckAntiFly();

        if (CanAddRange)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 3, LayerMask.GetMask("Tower")))
            {
                if (go1.GetComponent<TowerController>().addRange300 == 0)
                {
                    go1.GetComponent<TowerController>().AttackRange += 300;
                }
                go1.GetComponent<TowerController>().addRange300 = 0.5;
            }
        }

        if (addRange300 > 0)
        {
            addRange300 -= Time.deltaTime;
            if (addRange300 <= 0)
            {
                addRange300 = 0;
                AttackRange -= 300;
            }
        }

        if (ProvideCanNotMiss)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 3, LayerMask.GetMask("Tower")))
            {
                if (go1.GetComponent<TowerController>().canNotMissTimer == 0)
                {
                    go1.GetComponent<TowerController>().CanNotMiss = true;
                }
                go1.GetComponent<TowerController>().canNotMissTimer = 0.5;
            }
        }

        if (canNotMissTimer > 0)
        {
            canNotMissTimer -= Time.deltaTime;
            if (canNotMissTimer <= 0)
            {
                canNotMissTimer = 0;
                CanNotMiss = false;
            }
        }
    }

    /// <summary>
    /// 如果有加速特性,给周围防御塔增加攻速
    /// </summary>
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

    /// <summary>
    /// 更新攻速加成状态
    /// </summary>
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

    private void CheckBurnAttack()
    {
        if (BEffect == BurnEffect.BurnEffect30)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 5, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy"}));
            if (burnTimer > 0.5f)
            {
                foreach (Collider2D target in targets)
                {
                    target.GetComponent<EnemyController>().TakeMagicDamage(30);
                }
                burnTimer = 0;
            }
            burnTimer += Time.deltaTime;
        }
        else if (BEffect == BurnEffect.BurnEffect160)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            if (burnTimer > 0.5f)
            {
                foreach (Collider2D target in targets)
                {
                    target.GetComponent<EnemyController>().TakeMagicDamage(160);
                }
                burnTimer = 0;
            }
            burnTimer += Time.deltaTime;
        }
        else if (BEffect == BurnEffect.BurnEffect1250)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 7, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            if (burnTimer > 0.5f)
            {
                foreach (Collider2D target in targets)
                {
                    target.GetComponent<EnemyController>().TakeMagicDamage(1250);
                }
                burnTimer = 0;
            }
            burnTimer += Time.deltaTime;
        }
    }

    private void CheckAntiFly()
    {
        if (AFlyEffect == AntiFlyEffect.AntiFly1)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            foreach (var target in targets)
            {
                if (target.GetComponent<EnemyController>().IsFlying)
                {
                    if (target.GetComponent<EnemyController>().flyingDisable1Timer == 0)
                    {
                        target.GetComponent<EnemyController>().MovementSpeed -= 250;
                        target.GetComponent<EnemyController>().Armor -= 10;
                    }
                    target.GetComponent<EnemyController>().flyingDisable1Timer = 0.5f;
                }
            }
        }
    }
}
