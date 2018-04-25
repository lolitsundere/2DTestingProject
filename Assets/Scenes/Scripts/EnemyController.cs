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
    public Transform Front;
    public Transform Back;

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
            Front.localScale = new Vector3(0.55f * Health / MaxHealth, 0.07f, 1f);
            Front.localPosition = new Vector3(-((0.55f-Front.localScale.x)*3.2f)/2f, 0.8f, 0f);
        }
    }

    private void Start()
    {
        MaxHealth = 6;
        Health = MaxHealth;
        MovementSpeed = 446;
        Armor = 0;
        MagicResistance = 0.1f;

        Front = Instantiate(Front, transform);
        Back = Instantiate(Back, transform);
        Front.localPosition = new Vector3(0, 0.8f, 0);
        Back.localPosition = new Vector3(0, 0.8f, 0);

        //transform.GetComponent<NavMeshAgent>().speed = MovementSpeed / 4 * 3;
    }
}
