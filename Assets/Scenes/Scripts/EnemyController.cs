using System;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
    public int MaxHealth;
    public int Health;
    public int MovementSpeed;
    public int Armor;
    public float MagicResistance;

    public void TakeDamage(int damageAmount, TowerController.DamageType damageType)
    {
        switch (damageType)
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
        }
        if (Health > 0)
        {
            transform.GetComponent<HealthBarController>().Front.localScale = new Vector3(0.55f * (transform.GetComponent<EnemyController>().Health + 0.0f) / (transform.GetComponent<EnemyController>().MaxHealth + 0.0f), 0.07f, 1f);
            transform.GetComponent<HealthBarController>().Front.localPosition -= new Vector3((0.55f - transform.GetComponent<HealthBarController>().Front.localScale.x), 0f, 0f);
        }
    }

    private void Start()
    {
        MaxHealth = 6;
        Health = MaxHealth;
        MovementSpeed = 446;
        Armor = 0;
        MagicResistance = 0.1f;

        //transform.GetComponent<NavMeshAgent>().speed = MovementSpeed / 4 * 3;
    }
}
