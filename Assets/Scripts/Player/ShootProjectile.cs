using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

    public GameObject _projectile, Projectile2;
    GameObject Current;
    [Range(0, 1)]
    public float fireRate;
    private float timeStamp, timeStamp2, duration = 5f;
    bool isDouble = false, isRed = false, isTriple = false;


    void Start()
    {
        Current = _projectile;
        timeStamp = Time.time + (1 - fireRate);
    }


    void Update()
    {
        if (timeStamp < Time.time)
        {
            Shoot();
            timeStamp += (1 - fireRate);

        }

        if (isRed)
        {
            Current = Projectile2;
        }
        else
        {
            Current = _projectile;
        }
    }
    private void Shoot()
    {
        if (timeStamp2 < Time.time)
        {
            isDouble = false;
            isRed = false;
        }

        if (isDouble)
        {
            Instantiate(Current, transform.position - new Vector3(0.3f, 0, 0) + new Vector3(0, 1, 0), _projectile.transform.rotation);
            Instantiate(Current, transform.position + new Vector3(0.3f, 0, 0) + new Vector3(0, 1, 0), _projectile.transform.rotation);


        }
        else

            Instantiate(Current, transform.position + new Vector3(0, 1, 0), _projectile.transform.rotation);

        if (isTriple)
        {
            for (int i = -2; i < 3; i++)
            {
                Instantiate(Current, new Vector3(i, -5, 0), Current.transform.rotation);
                Instantiate(Current, new Vector3(i, -5, 0), Current.transform.rotation);
                Instantiate(Current, new Vector3(i, -5, 0), Current.transform.rotation);
                isTriple = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Power Up"))
        {
            Destroy(collision.gameObject);
            isDouble = true;
            timeStamp2 = Time.time + duration;

        }

        if (collision.CompareTag("PowerUp2"))
        {
            Destroy(collision.gameObject);
            isRed = true;
            timeStamp2 = Time.time + duration;

        }

        if (collision.CompareTag("PowerUp3"))
        {
            Destroy(collision.gameObject);
            isTriple = true;

        }
    }
}
