using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BossAttack", 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y < 2)
        {
            transform.position = new Vector2(transform.position.x, 2f);
        }

    }


    void BossAttack()
    {

        Instantiate(projectile, transform.position + new Vector3(0, -1.5f), transform.rotation);
        Instantiate(projectile, transform.position + new Vector3(0, -1.5f), Quaternion.Euler(0, 0, 150));
        Instantiate(projectile, transform.position + new Vector3(0, -1.5f), Quaternion.Euler(0, 0, 210));



    }
}

