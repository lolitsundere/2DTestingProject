using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderEventHandler : MonoBehaviour
{
    /// <summary>
    /// 在敌人进入时触发
    /// </summary>
    public event Action<GameObject> EnemyEnterEvent;

    /// <summary>
    /// 在敌人离开时触发
    /// </summary>
    public event Action<GameObject> EnemyExitEvent;

    /// <summary>
    /// 在敌人停留时触发
    /// </summary>
    public event Action<GameObject> EnemyStayEvent;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "InvisibleEnemy")
        {
            if (EnemyEnterEvent != null)
            {
                EnemyEnterEvent(other.gameObject);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "InvisibleEnemy")
        {
            if (EnemyExitEvent != null)
            {
                EnemyExitEvent(other.gameObject); 
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "InvisibleEnemy")
        {
            if (EnemyStayEvent != null)
            {
                EnemyStayEvent(other.gameObject);
            }
        }
    }
    
}
