﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TowerController : MonoBehaviour
{

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
                if (attackSpeed >= 20)
                {
                    attackTime = basicAttackTime / (attackSpeed * 0.01);
                }
                else
                {
                    attackTime = basicAttackTime / (20 * 0.01);
                }
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
            if (attackSpeed >= 20)
            {
                attackTime = basicAttackTime / (attackSpeed * 0.01);
            }
            else
            {
                attackTime = basicAttackTime / (20 * 0.01);
            }
        }
    }

    public int MaxTargetAmount;
    private float basicPhysicalDamage;
    public float BasicPhysicalDamage
    {
        set
        {
            basicPhysicalDamage = value;
            PhysicalDamage = value;
        }
        get
        {
            return basicPhysicalDamage;
        }
    }
    public float PhysicalDamage;
    public Color AttackColor;

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
                switch (value)
                {
                    case 400:
                        Instantiate(Resources.Load("AttackRanges/AttackRange400"), transform);
                        break;
                    case 500:
                        Instantiate(Resources.Load("AttackRanges/AttackRange500"), transform);
                        break;
                    case 600:
                        Instantiate(Resources.Load("AttackRanges/AttackRange600"), transform);
                        break;
                    case 700:
                        Instantiate(Resources.Load("AttackRanges/AttackRange700"), transform);
                        break;
                    case 800:
                        Instantiate(Resources.Load("AttackRanges/AttackRange800"), transform);
                        break;
                    case 900:
                        Instantiate(Resources.Load("AttackRanges/AttackRange900"), transform);
                        break;
                    case 1000:
                        Instantiate(Resources.Load("AttackRanges/AttackRange1000"), transform);
                        break;
                    case 1100:
                        Instantiate(Resources.Load("AttackRanges/AttackRange1100"), transform);
                        break;
                    case 1200:
                        Instantiate(Resources.Load("AttackRanges/AttackRange1200"), transform);
                        break;
                    case 1300:
                        Instantiate(Resources.Load("AttackRanges/AttackRange1300"), transform);
                        break;
                    case 5000:
                        Instantiate(Resources.Load("AttackRanges/AttackRange5000"), transform);
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

    public float attackTimer;
    public double attackTime;

    public float DamageDealed;
    private int mvpLevel;
    public int MVPLevel
    {
        get { return mvpLevel; }
        set
        {
            mvpLevel = value;
            PhysicalDamage = BasicPhysicalDamage * (1f + 0.1f * mvpLevel);
        }
    }
    public List<Collider2D> MvpAuraTargetsList = new List<Collider2D>();

    public String TowerDescription;

    public enum AttackSlowEffect { SlowEffect0, SlowEffect60, SlowEffect90, SlowEffect120, SlowEffect150, SlowEffect180, SlowEffect480 };
    public enum AttackSpeedAccelerateEffect { AccelerateEffect0, AccelerateEffect20, AccelerateEffect30, AccelerateEffect40, AccelerateEffect50, AccelerateEffect60, AccelerateEffect70, AccelerateEffect250 };
    public enum AttackPoisonEffect { PoisonEffect0, PoisonEffect1, PoisonEffect2, PoisonEffect4, PoisonEffect8, PoisonEffect16, PoisonEffect64 };
    public enum AttackArmorReduceEffect { ArmorReduceEffect0, ArmorReduceEffect1, ArmorReduceEffect2, ArmorReduceEffect4, ArmorReduceEffect8, ArmorReduceEffect16, ArmorReduceEffect20, ArmorReduceEffect30, ArmorReduceEffect64 };
    public enum AttackSplashEffect { SplashEffect0, SplashEffect1, SplashEffect2, SplashEffect3, SplashEffect4, SplashEffect5, SplashEffect6 };
    public enum BurnEffect { BurnEffect0, BurnEffect30, BurnEffect160, BurnEffect1250 };
    public enum AntiFlyEffect { AnitFly0, AntiFly1, AntiFly2 }

    public bool CanMagicSplash;
    public bool CanStun;
    public bool CanStoneGaze;
    public bool CanFrozenAttack;
    public bool CanBreakInvisibility;
    public bool CanCrit;
    public bool CanLightingChain;
    public bool CanHeal;
    public bool ProvideAddRange;
    public bool ProvideCanNotMiss;
    public bool ProvideSpellImmunity;
    public bool ProvideArmorReduceAura15;
    public bool ProvideArmorReduceAura30;
    public bool ProvideGreedy;
    public bool ProvideInspire;
    public bool ProvideLightingChain;
    public bool HasFrozenAura;

    public bool Greedy;
    public bool SpellImmunity;
    internal bool canNotMiss;
    private double canNotMissTimer;
    private float burnTimer;
    private double addRange300;

    public int LightingChainDamage;

    public AttackSlowEffect AtkSlowEffect;
    public AttackPoisonEffect AtkPoisonEffect;
    public List<AttackSpeedAccelerateEffect> AccelerateEffectList = new List<AttackSpeedAccelerateEffect>();
    public AttackArmorReduceEffect AtkArmorReduceEffect;
    public AttackSplashEffect AtkSplashEffect;
    public BurnEffect BEffect;
    public AntiFlyEffect AFlyEffect;

    private double accelerate20;
    private double accelerate30;
    private double accelerate40;
    private double accelerate50;
    private double accelerate60;
    private double accelerate70;
    private double accelerate250;

    private double inspireTimer;

    public double UntouchableTimer;
    
    private void PhysicalAttack()
    {
        if (PhysicalDamage > 0)
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
                    DrawAttackLine(target.gameObject);
                }
            }
            else
            {
                foreach (int i in Enumerable.Range(0, MaxTargetAmount))
                {
                    targets[i].GetComponent<EnemyController>().TakeTowerAttack(this);
                    DrawAttackLine(targets[i].gameObject);
                }
            }
            attackTimer = 0;
        }
    }

    private void DrawAttackLine(GameObject enemy)
    {
        var temp = (GameObject)Instantiate(Resources.Load("Line"), transform);
        var line = temp.GetComponent<LineRenderer>();
        line.SetPosition(0, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1));
        line.SetPosition(1, new Vector3(enemy.transform.position.x, enemy.transform.position.y, enemy.transform.position.z - 1));
        line.startColor = AttackColor;
        line.endColor = AttackColor;
        StartCoroutine(ClearAttackLine(line));
    }

    private IEnumerator ClearAttackLine(LineRenderer line)
    {
        yield return new WaitForSeconds(0.1f);
        Destroy(line.gameObject);
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
        SpellImmunity = false;
        CheckTowerAroundForAcceleration();
        CheckAccelerateState();
        CheckBurnAttack();
        CheckAntiFly();
        CheckTowerAroundForSpellImmunity();
        UpdateMVPMagicResistanceDownAura();

        if (ProvideInspire)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 5, LayerMask.GetMask("Tower")))
            {
                if (go1.GetComponent<TowerController>().inspireTimer == 0)
                {
                    go1.GetComponent<TowerController>().PhysicalDamage += basicPhysicalDamage/2;
                }
                go1.GetComponent<TowerController>().inspireTimer = 0.5;
            }
        }
        if (inspireTimer > 0)
        {
            inspireTimer -= Time.deltaTime;
            if (inspireTimer <= 0)
            {
                inspireTimer = 0;
                PhysicalDamage -= basicPhysicalDamage / 2;
            }
        }


        if (ProvideAddRange)
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

        if (HasFrozenAura)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 3, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            foreach (var target in targets)
            {
                if (target.GetComponent<EnemyController>().frozenTimer == 0)
                {
                    float movementSpeedDiff = 0;
                    if (target.GetComponent<EnemyController>().attackSlow60Timer > 0)
                    {
                        movementSpeedDiff += 60;
                    }
                    if (target.GetComponent<EnemyController>().attackSlow90Timer > 0)
                    {
                        movementSpeedDiff += 90;
                    }
                    if (target.GetComponent<EnemyController>().attackSlow120Timer > 0)
                    {
                        movementSpeedDiff += 120;
                    }
                    if (target.GetComponent<EnemyController>().attackSlow150Timer > 0)
                    {
                        movementSpeedDiff += 150;
                    }
                    if (target.GetComponent<EnemyController>().attackSlow180Timer > 0)
                    {
                        movementSpeedDiff += 180;
                    }
                    if (target.GetComponent<EnemyController>().attackSlow480Timer > 0)
                    {
                        movementSpeedDiff += 480;
                    }

                    target.GetComponent<EnemyController>().MovementSpeed = (target.GetComponent<EnemyController>().MovementSpeed + movementSpeedDiff) * 0.25f - movementSpeedDiff;
                }
                target.GetComponent<EnemyController>().frozenTimer = 0.5f;
            }
        }

        if (ProvideCanNotMiss)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 3, LayerMask.GetMask("Tower")))
            {
                if (go1.GetComponent<TowerController>().canNotMissTimer == 0)
                {
                    go1.GetComponent<TowerController>().canNotMiss = true;
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
                canNotMiss = false;
            }
        }

        if (UntouchableTimer > 0)
        {
            UntouchableTimer -= Time.deltaTime;
            if (UntouchableTimer <= 0)
            {
                UntouchableTimer = 0;
                AttackSpeed += 300;
            }
        }

        if (ProvideGreedy)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 8, LayerMask.GetMask("Tower")))
            {
                go1.GetComponent<TowerController>().Greedy = true;
            }
        }

        if (ProvideArmorReduceAura15)
        {
            foreach (var target in Physics2D.OverlapCircleAll(transform.position, 8, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" })))
            {
                if (!target.GetComponent<EnemyController>().SpellImmunity)
                {
                    if (target.GetComponent<EnemyController>().ArmorReduce15Timer == 0)
                    {
                        target.GetComponent<EnemyController>().Armor -= 15;
                    }
                    target.GetComponent<EnemyController>().ArmorReduce15Timer = 0.5f;
                }
            }
        }
        if (ProvideArmorReduceAura30)
        {
            foreach (var target in Physics2D.OverlapCircleAll(transform.position, 12, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" })))
            {
                if (!target.GetComponent<EnemyController>().SpellImmunity)
                {
                    if (target.GetComponent<EnemyController>().ArmorReduce30Timer == 0)
                    {
                        target.GetComponent<EnemyController>().Armor -= 30;
                    }
                    target.GetComponent<EnemyController>().ArmorReduce30Timer = 0.5f;
                }
            }

        }

        if (ProvideLightingChain)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 2, LayerMask.GetMask("Tower")))
            {
                go1.GetComponent<TowerController>().CanLightingChain = true;
                if (go1.GetComponent<TowerController>().LightingChainDamage < 500)
                {
                    go1.GetComponent<TowerController>().LightingChainDamage = 500;
                }
            }

        }
    }

    /// <summary>
    /// 如果有加速特性,给周围防御塔增加攻速
    /// </summary>
    private void CheckTowerAroundForAcceleration()
    {
        foreach (AttackSpeedAccelerateEffect AccelerateEffect in AccelerateEffectList)
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
            if (AccelerateEffect == AttackSpeedAccelerateEffect.AccelerateEffect250)
            {
                foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 1.5f, LayerMask.GetMask("Tower")))
                {
                    if (go1.GetComponent<TowerController>().accelerate250 == 0)
                    {
                        go1.GetComponent<TowerController>().AttackSpeed += 250;
                    }
                    go1.GetComponent<TowerController>().accelerate250 = 0.5;
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

        if (accelerate250 > 0)
        {
            accelerate250 -= Time.deltaTime;
            if (accelerate250 <= 0)
            {
                accelerate250 = 0;
                AttackSpeed -= 250;
            }
        }
    }


    /// <summary>
    /// 如果有魔免特性,给周围防御塔增加魔免
    /// </summary>
    private void CheckTowerAroundForSpellImmunity ()
    {
        if (ProvideSpellImmunity)
        {
            foreach (Collider2D go1 in Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask("Tower")))
            {
                go1.GetComponent<TowerController>().SpellImmunity = true;
            }
        }
    }

    /// <summary>
    /// 更新燃烧攻击状态
    /// </summary>
    private void CheckBurnAttack()
    {
        if (BEffect == BurnEffect.BurnEffect30)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 5, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy"}));
            if (burnTimer > 0.5f)
            {
                foreach (Collider2D target in targets)
                {
                    target.GetComponent<EnemyController>().TakeMagicDamage(this,30);
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
                    target.GetComponent<EnemyController>().TakeMagicDamage(this,160);
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
                    target.GetComponent<EnemyController>().TakeMagicDamage(this,1250);
                }
                burnTimer = 0;
            }
            burnTimer += Time.deltaTime;
        }
    }

    /// <summary>
    /// 更新飞行控制状态
    /// </summary>
    private void CheckAntiFly()
    {
        if (AFlyEffect == AntiFlyEffect.AntiFly1)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            foreach (var target in targets)
            {
                if (target.GetComponent<EnemyController>().IsFlying && !target.GetComponent<EnemyController>().SpellImmunity)
                {
                    if (target.GetComponent<EnemyController>().flyingDisable1Timer1 == 0)
                    {
                        target.GetComponent<EnemyController>().MovementSpeed -= 250;
                        target.GetComponent<EnemyController>().Armor -= 10;
                    }
                    target.GetComponent<EnemyController>().flyingDisable1Timer1 = 0.5f;
                }
            }
        }
        else if (AFlyEffect == AntiFlyEffect.AntiFly2)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
            foreach (var target in targets)
            {
                if (target.GetComponent<EnemyController>().IsFlying)
                {
                    if (target.GetComponent<EnemyController>().flyingDisable1Timer2 == 0)
                    {
                        target.GetComponent<EnemyController>().MovementSpeed -= 250;
                        target.GetComponent<EnemyController>().Armor -= 10;
                        target.GetComponent<EnemyController>().MagicResistance -= 0.5f;
                    }
                    target.GetComponent<EnemyController>().flyingDisable1Timer2 = 0.5f;
                }
            }
        }
    }

    /// <summary>
    /// 更新MVP光环状态
    /// </summary>
    private void UpdateMVPMagicResistanceDownAura()
    {
        var targets = Physics2D.OverlapCircleAll(transform.position, 6, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
        foreach (var target in targets)
        {
            if (!MvpAuraTargetsList.Contains(target))
            {
                target.GetComponent<EnemyController>().MagicResistance -= 0.1f * MVPLevel;
            }
        }
        foreach (var target in MvpAuraTargetsList)
        {
            try
            {
                if (!targets.Contains(target))
                {
                    target.GetComponent<EnemyController>().MagicResistance += 0.1f * MVPLevel;
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
        MvpAuraTargetsList = targets.ToList();
    }
}
