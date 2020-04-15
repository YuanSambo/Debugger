using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    float MaxHP;

    // Start is called before the first frame update
    void Start()
    {

        MaxHP = GetComponent<EnemyScript>().data.Health;
        slider.maxValue = MaxHP;
        slider.value = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = GetComponent<EnemyHealth>().hp;
    }
}
