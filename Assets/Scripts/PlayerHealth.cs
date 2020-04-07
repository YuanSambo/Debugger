using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public FloatVariable health;
    public GameEvent PlayerDeathEvent;

    private void Start()
    {
        health.Value = health.initialValue;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            health.SetValue(--health.Value);
            if (health.Value == 0)
            {
                PlayerDeathEvent.Raise();
            }
        }
    }



}
