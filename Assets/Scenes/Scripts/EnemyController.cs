using System;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    public int MaxHealth;
    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            if (value < health)
            {
                if (CanRun && UnityEngine.Random.value <= 0.15)
                {
                    if (runingTimer == 0)
                    {
                        float movementSpeedDiff = 0;
                        if (attackSlow60Timer > 0)
                        {
                            movementSpeedDiff += 60;
                        }
                        if (attackSlow90Timer > 0)
                        {
                            movementSpeedDiff += 90;
                        }
                        if (attackSlow120Timer > 0)
                        {
                            movementSpeedDiff += 120;
                        }
                        if (attackSlow150Timer > 0)
                        {
                            movementSpeedDiff += 150;
                        }
                        if (attackSlow180Timer > 0)
                        {
                            movementSpeedDiff += 180;
                        }
                        if (attackSlow480Timer > 0)
                        {
                            movementSpeedDiff += 480;
                        }

                        MovementSpeed = (MovementSpeed + movementSpeedDiff) * 1.5f - movementSpeedDiff;
                    }
                    runingTimer = 2;
                }
                if (Refractable)
                {
                    if (RefractionCharge <= 0)
                    {
                        if (UnityEngine.Random.value < 0.15f)
                        {
                            RefractionCharge = 3;
                        }
                        health = value;
                    }
                    else
                    {
                        RefractionCharge--;
                    }
                }
                else
                {
                    health = value;
                }
            }
            else
            {
                health = value;
            }
        }
    }
    private int health;
    private Vector2 LastLocation;

    private float movementSpeed;
    public float MovementSpeed
    { 
        get
        {
            return movementSpeed;
        }
        set
        {
            if (value != movementSpeed)
            {
                movementSpeed = value;
                if (movementSpeed > 100)
                {
                    nav.speed = movementSpeed / 400 * 3;
                }
                else
                {
                    nav.speed = 100 / 400 * 3;
                }
            }
        }
    }

    public int Armor;
    public float MagicResistance;
    public Transform Front;
    public Transform Back;
    public NavMeshAgent nav;
    public bool IsFlying;
    public bool IsInvisible;
    public float Evation;
    public bool Disarmble;
    public bool Refractable;
    public bool SpellImmunity;
    public bool Untouchable;
    public bool CanRun;
    public bool CanStackArmor;

    private int RefractionCharge = 0;

    public int ExperienceAndGold;
    public int MaxAmount;
    public int MaxDamageToPlayer;
    public String EnemyDescription;

    private double attackSlow60Timer;
    private double attackSlow90Timer;
    private double attackSlow120Timer;
    private double attackSlow150Timer;
    private double attackSlow180Timer;
    private double attackSlow480Timer;

    public double flyingDisable1Timer1;
    public double flyingDisable1Timer2;

    private double poison1Timer;
    private double poison2Timer;
    private double poison4Timer;
    private double poison8Timer;
    private double poison16Timer;
    private double poison64Timer;

    internal TowerController poison1Tower;
    internal TowerController poison2Tower;
    internal TowerController poison4Tower;
    internal TowerController poison8Tower;
    internal TowerController poison16Tower;
    internal TowerController poison64Tower;

    private double attackArmorReduce1Timer;
    private double attackArmorReduce2Timer;
    private double attackArmorReduce4Timer;
    private double attackArmorReduce8Timer;
    private double attackArmorReduce16Timer;
    private double attackArmorReduce64Timer;

    private double runingTimer;


    /// <summary>
    /// 受到物理攻击
    /// </summary>
    /// <param name="tower"></param>
    public void TakeTowerAttack(TowerController tower)
    {
        if (Untouchable)
        {
            if (tower.UntouchableTimer == 0)
            {
                tower.AttackSpeed -= 300;
            }
            tower.UntouchableTimer = 5f;
        }
        if (tower.canNotMiss || Evation <= UnityEngine.Random.value)
        {
            if (!SpellImmunity)
            {
                switch (tower.AtkSlowEffect)
                {
                    case TowerController.AttackSlowEffect.SlowEffect60:
                        if (attackSlow60Timer == 0)
                        {
                            MovementSpeed -= 60;
                        }
                        attackSlow60Timer = 2f;
                        break;
                    case TowerController.AttackSlowEffect.SlowEffect90:
                        if (attackSlow90Timer == 0)
                        {
                            MovementSpeed -= 90;
                        }
                        attackSlow90Timer = 2f;
                        break;
                    case TowerController.AttackSlowEffect.SlowEffect120:
                        if (attackSlow120Timer == 0)
                        {
                            MovementSpeed -= 120;
                        }
                        attackSlow120Timer = 2f;
                        break;
                    case TowerController.AttackSlowEffect.SlowEffect150:
                        if (attackSlow150Timer == 0)
                        {
                            MovementSpeed -= 150;
                        }
                        attackSlow150Timer = 2f;
                        break;
                    case TowerController.AttackSlowEffect.SlowEffect180:
                        if (attackSlow180Timer == 0)
                        {
                            MovementSpeed -= 180;
                        }
                        attackSlow180Timer = 2f;
                        break;
                    case TowerController.AttackSlowEffect.SlowEffect480:
                        if (attackSlow480Timer == 0)
                        {
                            MovementSpeed -= 480;
                        }
                        attackSlow480Timer = 2f;
                        break;
                }

                switch (tower.AtkPoisonEffect)
                {
                    case TowerController.AttackPoisonEffect.PoisonEffect1:
                        poison1Tower = tower;
                        poison1Timer = 5.1f;
                        break;
                    case TowerController.AttackPoisonEffect.PoisonEffect2:
                        poison2Timer = 5.1f;
                        poison2Tower = tower;
                        break;
                    case TowerController.AttackPoisonEffect.PoisonEffect4:
                        poison4Tower = tower;
                        poison4Timer = 5.1f;
                        break;
                    case TowerController.AttackPoisonEffect.PoisonEffect8:
                        poison8Tower = tower;
                        poison8Timer = 5.1f;
                        break;
                    case TowerController.AttackPoisonEffect.PoisonEffect16:
                        poison16Tower = tower;
                        poison16Timer = 5.1f;
                        break;
                    case TowerController.AttackPoisonEffect.PoisonEffect64:
                        poison64Tower = tower;
                        poison64Timer = 5.1f;
                        break;
                }

                switch (tower.AtkArmorReduceEffect)
                {
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect1:
                        if (attackArmorReduce1Timer == 0)
                        {
                            Armor -= 1;
                        }
                        attackArmorReduce1Timer = 2f;
                        break;
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect2:
                        if (attackArmorReduce2Timer == 0)
                        {
                            Armor -= 2;
                        }
                        attackArmorReduce2Timer = 2f;
                        break;
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect4:
                        if (attackArmorReduce4Timer == 0)
                        {
                            Armor -= 4;
                        }
                        attackArmorReduce4Timer = 2f;
                        break;
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect8:
                        if (attackArmorReduce8Timer == 0)
                        {
                            Armor -= 8;
                        }
                        attackArmorReduce8Timer = 2f;
                        break;
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect16:
                        if (attackArmorReduce16Timer == 0)
                        {
                            Armor -= 16;
                        }
                        attackArmorReduce16Timer = 2f;
                        break;
                    case TowerController.AttackArmorReduceEffect.ArmorReduceEffect64:
                        if (attackArmorReduce64Timer == 0)
                        {
                            Armor -= 64;
                        }
                        attackArmorReduce64Timer = 2f;
                        break;
                }

                if (tower.CanLightingChain && UnityEngine.Random.value <= 0.3)
                {
                    TakeLightingChain(tower, tower.LightingChainDamage, 5);
                }
            }


            int damage=0;
            if (tower.CanCrit && UnityEngine.Random.value <= 0.1)
            {
                damage = Mathf.RoundToInt((1f - (0.05f * Armor / (1f + 0.05f * Mathf.Abs(Armor)))) * tower.PhysicalDamage * 5);
            }
            else
            {
                damage = Mathf.RoundToInt((1f - (0.05f * Armor / (1f + 0.05f * Mathf.Abs(Armor)))) * tower.PhysicalDamage);
            }
            
            if (damage > Health)
            {
                tower.DamageDealed += Health;
            }
            else
            {
                tower.DamageDealed += damage;
            }

            Health -= damage;


            if (tower.CanMagicSplash)
            {
                foreach (Collider2D enemy in Physics2D.OverlapCircleAll(transform.position, 2, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" })))
                {
                    enemy.GetComponent<EnemyController>().TakeMagicDamage(tower, tower.PhysicalDamage);
                }
            }

            if (tower.CanHeal && UnityEngine.Random.value <= 0.01)
            {
                var wm = FindObjectOfType<WorldManager>();
                if (wm.Health < 100)
                {
                    wm.Health++;
                }
            }

            if (CanStackArmor)
            {
                Armor += 5;
            }

            switch (tower.AtkSplashEffect)
            {
                case TowerController.AttackSplashEffect.SplashEffect1:
                    var enemyNear = Physics2D.OverlapCircleAll(transform.position, 3, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower,Convert.ToInt32(damage * 0.3f));
                        }
                    }
                    break;

                case TowerController.AttackSplashEffect.SplashEffect2:
                    enemyNear = Physics2D.OverlapCircleAll(transform.position, 3.5f, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower,Convert.ToInt32(damage * 0.4f));
                        }
                    }
                    break;

                case TowerController.AttackSplashEffect.SplashEffect3:
                    enemyNear = Physics2D.OverlapCircleAll(transform.position, 4, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower,Convert.ToInt32(damage * 0.5f));
                        }
                    }
                    break;

                case TowerController.AttackSplashEffect.SplashEffect4:
                    enemyNear = Physics2D.OverlapCircleAll(transform.position, 4.5f, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower,Convert.ToInt32(damage * 0.6f));
                        }
                    }
                    break;

                case TowerController.AttackSplashEffect.SplashEffect5:
                    enemyNear = Physics2D.OverlapCircleAll(transform.position, 5, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower,Convert.ToInt32(damage * 0.7f));
                        }
                    }
                    break;

                case TowerController.AttackSplashEffect.SplashEffect6:
                    enemyNear = Physics2D.OverlapCircleAll(transform.position, 7, LayerMask.GetMask(new string[] { "Enemy", "InvisibleEnemy" }));
                    foreach (Collider2D enemy in enemyNear)
                    {
                        if (enemy.gameObject != transform.gameObject)
                        {
                            enemy.GetComponent<EnemyController>().TakePureDamage(tower, damage);
                        }
                    }
                    break;
            }
            HealthBarChange();
        }
    }

    /// <summary>
    /// 受到闪电链伤害
    /// </summary>
    /// <param name="damage"></param>
    /// <param name="count"></param>
    public void TakeLightingChain(TowerController tower,int damage, int count)
    {
        if (count == 0)
        {
            return;
        }

        TakeMagicDamage(tower,damage);

        var targets = Physics2D.OverlapCircleAll(transform.position, 30, LayerMask.GetMask("Enemy"));
        if (targets.Length > 0)
        {
            int i = new System.Random().Next(targets.Length);
            targets[i].GetComponent<EnemyController>().TakeLightingChain(tower, damage, --count);
        }
    }


    private void FixedUpdate()
    {
        if (LastLocation.x < transform.localPosition.x)
        {
            transform.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            transform.GetComponent<SpriteRenderer>().flipX = false;
        }
        LastLocation = transform.localPosition;

    }

    /// <summary>
    /// 受到魔法伤害
    /// </summary>
    /// <param name="damageAmount"></param>
    public void TakeMagicDamage(TowerController tower, int damageAmount)
    {
        if (!SpellImmunity)
        {
            double damage = Mathf.Round((1 - MagicResistance) * damageAmount);

            if (damage > Health)
            {
                tower.DamageDealed += Health;
            }
            else
            {
                tower.DamageDealed += Convert.ToInt32(damage);
            }

            Health -= Convert.ToInt32(damage);
            HealthBarChange();
        }
    }

    /// <summary>
    /// 受到纯粹伤害
    /// </summary>
    /// <param name="damageAmount"></param>
    public void TakePureDamage(TowerController tower, int damageAmount)
    {
        if (damageAmount > Health)
        {
            tower.DamageDealed += Health;
        }
        else
        {
            tower.DamageDealed += damageAmount;
        }
        Health -= damageAmount;
        HealthBarChange();
    }

    /// <summary>
    /// 改变血条
    /// </summary>
    private void HealthBarChange()
    {
        if (Health > 0)
        {
            Front.localScale = new Vector3(0.55f * Health / MaxHealth, 0.07f, 1f);
            Front.localPosition = new Vector3(-((0.55f - Front.localScale.x) * 3.2f) / 2f, 0.8f, 0f);
        }
    }

    private void Start()
    {
        Front = Instantiate(Front, transform);
        Back = Instantiate(Back, transform);
        Front.localPosition = new Vector3(0, 0.8f, 0);
        Back.localPosition = new Vector3(0, 0.8f, 0);
        if (MaxDamageToPlayer == 0)
        {
            MaxDamageToPlayer = 13;
        }
    }

    private void Update()
    {
        CheckSlowState();
        CheckPoisonState();
        CheckArmorReduceState();
        CheckForFlyingDisable();
        CheckColor();
        CheckRuningState();
        CheckForDisArm();
        CheckForInvision();
    }

    /// <summary>
    /// 根据状态改变颜色
    /// </summary>
    private void CheckColor()
    {
        bool isSlowed = attackSlow60Timer != 0 || attackSlow90Timer != 0 || attackSlow120Timer != 0 || attackSlow150Timer != 0 || attackSlow180Timer != 0 || attackSlow480Timer != 0;
        bool isPoisoned = poison1Timer != 0 || poison2Timer != 0 || poison4Timer != 0 || poison8Timer != 0 || poison16Timer != 0 || poison64Timer != 0;
        bool isArmorReduced = attackArmorReduce1Timer != 0 || attackArmorReduce2Timer != 0 || attackArmorReduce4Timer != 0 || attackArmorReduce8Timer != 0 || attackArmorReduce16Timer != 0 || attackArmorReduce64Timer != 0;

        if (isSlowed && isPoisoned && isArmorReduced)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(25f / 255f, 25f / 255f, 25f/255f);
        }
        else if (isSlowed && isPoisoned)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(5f / 255f, 171f / 255f, 150f / 255f);
        }
        else if (isSlowed && isArmorReduced)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(96f / 255f, 94f / 255f, 191f / 255f);
        }
        else if (isPoisoned && isArmorReduced)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(104f / 255f, 116f / 255f, 72f / 255f);
        }

        else if (isSlowed)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 1f, 1f);
        }
        else if (isPoisoned)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(118f/ 255f, 1f, 101f / 255f);
        }
        else if (isArmorReduced)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(189f / 255f, 129f/255f, 212f / 255f);
        }
        else
        {
            transform.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    /// <summary>
    /// 更新中毒状态
    /// </summary>
    private void CheckPoisonState()
    {
        if (poison1Timer > 0)
        {
            poison1Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison1Timer*100)%100 == 0)
            {
                TakeMagicDamage(poison1Tower,1);
            }
            if (poison1Timer <= 0)
            {
                poison1Timer = 0;
            }
        }

        if (poison2Timer > 0)
        {
            poison2Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison2Timer * 100) % 100 == 0)
            {
                TakeMagicDamage(poison2Tower,2);
            }
            if (poison2Timer <= 0)
            {
                poison2Timer = 0;
            }
        }

        if (poison4Timer > 0)
        {
            poison4Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison4Timer * 100) % 100 == 0)
            {
                TakeMagicDamage(poison4Tower,4);
            }
            if (poison4Timer <= 0)
            {
                poison4Timer = 0;
            }
        }

        if (poison8Timer > 0)
        {
            poison8Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison8Timer * 100) % 100 == 0)
            {
                TakeMagicDamage(poison8Tower,8);
            }
            if (poison8Timer <= 0)
            {
                poison8Timer = 0;
            }
        }

        if (poison16Timer > 0)
        {
            poison16Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison16Timer * 100) % 100 == 0)
            {
                TakeMagicDamage(poison16Tower,16);
            }
            if (poison16Timer <= 0)
            {
                poison16Timer = 0;
            }
        }

        if (poison64Timer > 0)
        {
            poison64Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison64Timer * 100) % 100 == 0)
            {
                TakeMagicDamage(poison64Tower,64);
            }
            if (poison64Timer <= 0)
            {
                poison64Timer = 0;
            }
        }
    }

    /// <summary>
    /// 更新减速状态
    /// </summary>
    private void CheckSlowState()
    {
        if (attackSlow60Timer > 0)
        {
            attackSlow60Timer -= Time.deltaTime;
            if (attackSlow60Timer <= 0)
            {
                attackSlow60Timer = 0;
                MovementSpeed += 60;
            }
        }

        if (attackSlow90Timer > 0)
        {
            attackSlow90Timer -= Time.deltaTime;
            if (attackSlow90Timer <= 0)
            {
                attackSlow90Timer = 0;
                MovementSpeed += 90;
            }
        }

        if (attackSlow120Timer > 0)
        {
            attackSlow120Timer -= Time.deltaTime;
            if (attackSlow120Timer <= 0)
            {
                attackSlow120Timer = 0;
                MovementSpeed += 120;
            }
        }

        if (attackSlow150Timer > 0)
        {
            attackSlow150Timer -= Time.deltaTime;
            if (attackSlow150Timer <= 0)
            {
                attackSlow150Timer = 0;
                MovementSpeed += 150;
            }
        }

        if (attackSlow180Timer > 0)
        {
            attackSlow180Timer -= Time.deltaTime;
            if (attackSlow180Timer <= 0)
            {
                attackSlow180Timer = 0;
                MovementSpeed += 180;
            }
        }

        if (attackSlow480Timer > 0)
        {
            attackSlow480Timer -= Time.deltaTime;
            if (attackSlow480Timer <= 0)
            {
                attackSlow480Timer = 0;
                MovementSpeed += 480;
            }
        }
    }

    /// <summary>
    /// 更新减甲状态
    /// </summary>
    private void CheckArmorReduceState()
    {
        if (attackArmorReduce1Timer > 0)
        {
            attackArmorReduce1Timer -= Time.deltaTime;
            if (attackArmorReduce1Timer <= 0)
            {
                attackArmorReduce1Timer = 0;
                Armor += 1;
            }
        }

        if (attackArmorReduce2Timer > 0)
        {
            attackArmorReduce2Timer -= Time.deltaTime;
            if (attackArmorReduce2Timer <= 0)
            {
                attackArmorReduce2Timer = 0;
                Armor += 2;
            }
        }

        if (attackArmorReduce4Timer > 0)
        {
            attackArmorReduce4Timer -= Time.deltaTime;
            if (attackArmorReduce4Timer <= 0)
            {
                attackArmorReduce4Timer = 0;
                Armor += 4;
            }
        }

        if (attackArmorReduce8Timer > 0)
        {
            attackArmorReduce8Timer -= Time.deltaTime;
            if (attackArmorReduce8Timer <= 0)
            {
                attackArmorReduce8Timer = 0;
                Armor += 8;
            }
        }

        if (attackArmorReduce16Timer > 0)
        {
            attackArmorReduce16Timer -= Time.deltaTime;
            if (attackArmorReduce16Timer <= 0)
            {
                attackArmorReduce16Timer = 0;
                Armor += 16;
            }
        }

        if (attackArmorReduce64Timer > 0)
        {
            attackArmorReduce64Timer -= Time.deltaTime;
            if (attackArmorReduce64Timer <= 0)
            {
                attackArmorReduce64Timer = 0;
                Armor += 64;
            }
        }
    }

    /// <summary>
    /// 更新周围防御塔缴械状态
    /// </summary>
    private void CheckForDisArm()
    {
        if (Disarmble)
        {
            var targets = Physics2D.OverlapCircleAll(transform.position, 1.3f, LayerMask.GetMask("Tower"));
            foreach (Collider2D target in targets)
            {
                target.GetComponent<TowerController>().attackTimer = 0f;
            }
        }
    }

    /// <summary>
    /// 更新隐身状态
    /// </summary>
    private void CheckForInvision()
    {

        if (IsInvisible)
        {
            var temp = Physics2D.OverlapCircleAll(transform.position, 6f, LayerMask.GetMask("Tower"));
            bool breaked = false;
            foreach (Collider2D tower in temp)
            {
                if (tower.GetComponent<TowerController>().CanBreakInvisibility)
                {
                    transform.GetComponent<SpriteRenderer>().enabled = true;
                    transform.tag = "Enemy";
                    gameObject.layer = 9;
                    breaked = true;
                }
            }

            if (!breaked)
            {
                transform.GetComponent<SpriteRenderer>().enabled = false;
                transform.tag = "InvisibleEnemy";
                gameObject.layer = 11;
            }
        }
    }

    /// <summary>
    /// 更新飞行控制状态
    /// </summary>
    private void CheckForFlyingDisable()
    {
        if (flyingDisable1Timer1 > 0)
        {
            flyingDisable1Timer1 -= Time.deltaTime;
            if (flyingDisable1Timer1 <= 0)
            {
                flyingDisable1Timer1 = 0;
                MovementSpeed += 250;
                Armor += 10;
            }
        }

        if (flyingDisable1Timer2 > 0)
        {
            flyingDisable1Timer2 -= Time.deltaTime;
            if (flyingDisable1Timer2 <= 0)
            {
                flyingDisable1Timer2 = 0;
                MovementSpeed += 250;
                Armor += 10;
                MagicResistance += 0.5f;
            }
        }
    }

    /// <summary>
    /// 更新奔跑状态
    /// </summary>
    private void CheckRuningState()
    {
        if (runingTimer > 0)
        {
            runingTimer -= Time.deltaTime;
            if (runingTimer <= 0)
            {
                runingTimer = 0;
                int movementSpeedDiff = 0;
                if (attackSlow60Timer > 0)
                {
                    movementSpeedDiff += 60;
                }
                if (attackSlow90Timer > 0)
                {
                    movementSpeedDiff += 90;
                }
                if (attackSlow120Timer > 0)
                {
                    movementSpeedDiff += 120;
                }
                if (attackSlow150Timer > 0)
                {
                    movementSpeedDiff += 150;
                }
                if (attackSlow180Timer > 0)
                {
                    movementSpeedDiff += 180;
                }
                if (attackSlow480Timer > 0)
                {
                    movementSpeedDiff += 480;
                }
                MovementSpeed = (MovementSpeed + movementSpeedDiff) / 1.5f - movementSpeedDiff;
            }
        }
    }

}
