using System;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour
{
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
    }
    
    private void Start()
    {
        Health = 3;
        MovementSpeed = 446;
        Armor = 0;
        MagicResistance = 0.1f;

        //transform.GetComponent<NavMeshAgent>().speed = MovementSpeed / 4 * 3;
    }
}
