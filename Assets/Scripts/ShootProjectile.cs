using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{

    public GameObject _projectile;
    [Range(0, 1)]
    public float fireRate;
    private float timeStamp;


    void Start()
    {
        //InvokeRepeating("Shoot", 1f, fireRate);
        // Set default Time Stamp
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
        Instantiate(_projectile, transform.position + new Vector3(0, 1, 0), _projectile.transform.rotation);

    }
}
