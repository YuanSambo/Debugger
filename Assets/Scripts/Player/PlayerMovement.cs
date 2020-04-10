using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed;
    void Update()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        transform.position += Vector3.right * moveHorizontal * Time.deltaTime * speed;
        transform.position += Vector3.up * moveVertical * Time.deltaTime * speed;

        // X Bounds
        if (transform.position.x > 2)
        {
            transform.position = new Vector2(2, transform.position.y);
        }
        else if (transform.position.x < -2)
        {
            transform.position = new Vector2(-2, transform.position.y);

        }

        // Y bounds
        if (transform.position.y > 4f)
        {
            transform.position = new Vector2(transform.position.x, 4f);
        }
        else if (transform.position.y < -4.5f)
        {
            transform.position = new Vector2(transform.position.x,-4.5f);

        }


    }
}
