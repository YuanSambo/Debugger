using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

    public GameObject _projectile;
    [Range(0, 1)]
    public float fireRate;
    private float timeStamp, timeStamp2, duration = 5f;
    bool isDouble = false;


    void Start()
    {

        timeStamp = Time.time + (1 - fireRate);
    }


    void Update()
    {
        if (timeStamp < Time.time)
        {
            Shoot();
            timeStamp += (1 - fireRate);

        }
    }
    private void Shoot()
    {

        if (isDouble)
        {
            Instantiate(_projectile, transform.position - new Vector3(0.3f, 0, 0) + new Vector3(0, 1, 0), _projectile.transform.rotation);
            Instantiate(_projectile, transform.position + new Vector3(0.3f, 0, 0) + new Vector3(0, 1, 0), _projectile.transform.rotation);
            if (timeStamp2 < Time.time)
            {
                isDouble = false;
            }

        }
        else

            Instantiate(_projectile, transform.position + new Vector3(0, 1, 0), _projectile.transform.rotation);



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Power Up"))
        {
            Destroy(collision.gameObject);
            isDouble = true;
            timeStamp2 = Time.time + duration;

        }
    }
}
