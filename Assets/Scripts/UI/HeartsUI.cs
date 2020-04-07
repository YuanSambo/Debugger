using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public FloatVariable health;
    public Image[] hearts;

    // Update is called once per frame
    void Update()
    {
        float hp = health.Value;
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < hp)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }

            if (hp == 0)
            {
                Destroy(gameObject);
            }

        }
    }
}
