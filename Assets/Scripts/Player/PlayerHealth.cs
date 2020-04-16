using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    public FloatVariable health;
    AudioSource hurtSound;
    public GameEvent PlayerDeathEvent;
    public bool ResetHP;

    private void Start()
    {
        hurtSound = GetComponent<AudioSource>();
        if (ResetHP)
        {
            health.Value = health.initialValue;

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Enemy") || collision.CompareTag("Projectile"))
        {
            Destroy(collision.gameObject);
            hurtSound.Play();
            health.SetValue(--health.Value);
        }

        else if (collision.CompareTag("Boss"))
        {
            health.SetValue(--health.Value);

        }
        if (health.Value == 0)
        {
            PlayerDeathEvent.Raise();
        }
    }





}
