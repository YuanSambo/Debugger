using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public ProjectileData _data;
    SpriteRenderer _sprite;
    float speed;

    void Start()
    {
        _sprite = GetComponent<SpriteRenderer>();
        _sprite.sprite = _data.sprite;
        speed = _data.speed;
    }

    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.up * Time.deltaTime * speed);

    }
}
