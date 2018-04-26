using System;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    public int MaxHealth;
    public int Health;

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
                nav.speed = movementSpeed / 400 * 3;
            }
        }
    }
    public int Armor;
    public float MagicResistance;
    public Transform Front;
    public Transform Back;
    public NavMeshAgent nav;

    private double attackSlow60Timer;
    private double attackSlow90Timer;
    private double attackSlow120Timer;
    private double attackSlow150Timer;
    private double attackSlow180Timer;
    private double attackSlow480Timer;

    private double poison1Timer;
    private double poison2Timer;
    private double poison4Timer;
    private double poison8Timer;
    private double poison16Timer;
    private double poison64Timer;

    public void TakeTowerAttack(TowerController tower)
    {
        /*       switch (damageType)
               {
                   case TowerController.DamageType.Physical:
                       var damage = (1 - (0.05 * Armor / (1 + 0.05 * Mathf.Abs(Armor)))) * damageAmount;
                       Health -= Convert.ToInt32(damage);
                       break;
                   case TowerController.DamageType.Magic:
                       damage = (1 - MagicResistance) * damageAmount;
                       Health -= Convert.ToInt32(damage);
                       break;
                   case TowerController.DamageType.Pure:
                       Health -= damageAmount;
                       break;
               }*/
        double damage = Mathf.Round((1 - (0.05f * Armor / (1 + 0.05f * Mathf.Abs(Armor)))) * tower.PhysicalDamage);
        Health -= Convert.ToInt32(damage);

        switch(tower.AtkSlowEffect)
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
                poison1Timer = 5.1f;
                break;
            case TowerController.AttackPoisonEffect.PoisonEffect2:
                poison2Timer = 5.1f;
                break;
            case TowerController.AttackPoisonEffect.PoisonEffect4:
                poison4Timer = 5.1f;
                break;
            case TowerController.AttackPoisonEffect.PoisonEffect8:
                poison8Timer = 5.1f;
                break;
            case TowerController.AttackPoisonEffect.PoisonEffect16:
                poison16Timer = 5.1f;
                break;
            case TowerController.AttackPoisonEffect.PoisonEffect64:
                poison64Timer = 5.1f;
                break;
        }


        HealthBarChange();
    }

    public void TakeMagicDamage(int damageAmount)
    {
        double damage = Mathf.Round((1 - MagicResistance) * damageAmount);
        Health -= Convert.ToInt32(damage);

        HealthBarChange();
    }

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
    }

    private void Update()
    {
        CheckSlowState();
        CheckPoisonState();
        CheckColor();

        if (MovementSpeed <100)
        {
            MovementSpeed = 100;
        }
    }

    private void CheckColor()
    {

        if ((attackSlow60Timer != 0 || attackSlow90Timer != 0 || attackSlow120Timer != 0 || attackSlow150Timer != 0 || attackSlow180Timer != 0 || attackSlow480Timer != 0) 
            && (poison1Timer != 0 || poison2Timer != 0 || poison4Timer != 0 || poison8Timer != 0 || poison16Timer != 0 || poison64Timer != 0))
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(5f / 255f, 171f / 255f, 150f/255f);
        }
        else if (attackSlow60Timer != 0 || attackSlow90Timer != 0 || attackSlow120Timer != 0 || attackSlow150Timer != 0 || attackSlow180Timer != 0 || attackSlow480Timer != 0)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 1f, 1f);
        }
        else if (poison1Timer != 0 || poison2Timer != 0 || poison4Timer != 0 || poison8Timer != 0 || poison16Timer != 0 || poison64Timer != 0)
        {
            transform.GetComponent<SpriteRenderer>().color = new Color(118/ 255f, 1f, 101f / 255f);
        }
        else
        {
            transform.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }

    private void CheckPoisonState()
    {
        if (poison1Timer > 0)
        {
            poison1Timer -= Time.deltaTime;
            if (Convert.ToInt32(poison1Timer*100)%100 == 0)
            {
                TakeMagicDamage(1);
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
                TakeMagicDamage(2);
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
                TakeMagicDamage(4);
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
                TakeMagicDamage(8);
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
                TakeMagicDamage(16);
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
                TakeMagicDamage(64);
            }
            if (poison64Timer <= 0)
            {
                poison64Timer = 0;
            }
        }
    }

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
}
