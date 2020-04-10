using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -6 || transform.position.y > 6)
        {
            Destroy(gameObject);
        }

        if (transform.position.x < -4 || transform.position.x > 4)
        {
            Destroy(gameObject);
        }
    }
}
