using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    Vector3 startPos;
    BoxCollider2D boxCollider;

    public FloatReference speed;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        boxCollider = GetComponent<BoxCollider2D>();

    }

    void Update()
    {
        transform.position += Vector3.down * Time.deltaTime * speed;
        if (boxCollider.size.y < -transform.position.y)
        {
            transform.position = startPos;
        }


    }



}