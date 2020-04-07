using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemyHealth : MonoBehaviour
{
    public FloatReference enemyHealth;
    public UnityEvent EnemyDeathEvent;
    private float hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = enemyHealth.Value;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Projectile")
        {
            hp--;
            Destroy(other.gameObject);
            if (hp <= 0)
            {
                Destroy(gameObject);
                EnemyDeathEvent.Invoke();
            }
            

        }



    }
}
