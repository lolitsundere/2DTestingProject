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
        var damage = (1 - (0.05 * Armor / (1 + 0.05 * Mathf.Abs(Armor)))) * tower.PhysicalDamage;
        Health -= Convert.ToInt32(damage);

        switch(tower.attackSlowEffect)
        {
            case TowerController.AttackSlowEffect.SlowEffect60:
                if (attackSlow60Timer == 0)
                {
                    MovementSpeed -= 60;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow60Timer = 2f;
                break;
            case TowerController.AttackSlowEffect.SlowEffect90:
                if (attackSlow90Timer == 0)
                {
                    MovementSpeed -= 90;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow90Timer = 2f;
                break;
            case TowerController.AttackSlowEffect.SlowEffect120:
                if (attackSlow120Timer == 0)
                {
                    MovementSpeed -= 120;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow120Timer = 2f;
                break;
            case TowerController.AttackSlowEffect.SlowEffect150:
                if (attackSlow150Timer == 0)
                {
                    MovementSpeed -= 150;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow150Timer = 2f;
                break;
            case TowerController.AttackSlowEffect.SlowEffect180:
                if (attackSlow180Timer == 0)
                {
                    MovementSpeed -= 180;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow180Timer = 2f;
                break;
            case TowerController.AttackSlowEffect.SlowEffect480:
                if (attackSlow480Timer == 0)
                {
                    MovementSpeed -= 480;
                    transform.GetComponent<SpriteRenderer>().color = new Color(71f / 255f, 133f / 133f, 1f);
                }
                attackSlow480Timer = 2f;
                break;
        }

        if (Health > 0)
        {
            Front.localScale = new Vector3(0.55f * Health / MaxHealth, 0.07f, 1f);
            Front.localPosition = new Vector3(-((0.55f-Front.localScale.x)*3.2f)/2f, 0.8f, 0f);
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

        if (MovementSpeed <100)
        {
            MovementSpeed = 100;
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

        if (attackSlow60Timer == 0 && attackSlow90Timer == 0 && attackSlow120Timer == 0 && attackSlow150Timer == 0 && attackSlow180Timer == 0 && attackSlow480Timer == 0)
        {
            transform.GetComponent<SpriteRenderer>().color = Color.white;
        }
    }
}
