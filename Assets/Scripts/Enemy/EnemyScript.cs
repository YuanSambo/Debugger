using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public EnemyData data;
    public FloatVariable multiplier;
    SpriteRenderer sprite;
    [HideInInspector]
    EnemyHealth health;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        health = GetComponent<EnemyHealth>();
        health.hp = data.Health;
        speed = data.speed * multiplier.initialValue;
        sprite.sprite = data.Sprite;

    }

    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.up * Time.deltaTime * speed);

    }
}
