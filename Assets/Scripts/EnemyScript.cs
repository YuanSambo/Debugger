using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyData data;
    private SpriteRenderer sprite;
    public FloatReference speed;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = data.Sprite;

    }

    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.up * Time.deltaTime * speed);

    }
}
