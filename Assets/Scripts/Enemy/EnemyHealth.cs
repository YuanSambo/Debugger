using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public UnityEvent EnemyDeathEvent;
    [HideInInspector]
    public float hp;


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Projectile")
        {
            hp--;
            Destroy(other.gameObject);
            if (hp <= 0)
            {
                EnemyDeathEvent.Invoke();
                Destroy(gameObject);
            }


        }



    }
}
