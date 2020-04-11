using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public UnityEvent EnemyDeathEvent;
    private float hp;
    public float enemyHealth;

    // Start is called before the first frame update
    void Start()
    {
        hp = enemyHealth;
    }

    // Update is called once per frame


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
