using UnityEngine;

public class WaveManager : MonoBehaviour

{
    public FloatVariable[] SpeedVariables;
    [Range(1, 20)]
    public float speed;
    private float timeStamp;

    private void Start()
    {
        timeStamp = Time.time + 1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        foreach (var speed in SpeedVariables)
        {
            if (timeStamp < Time.time)
            {
                timeStamp = Time.time + 1;
                speed.SetValue(this.speed +=0.1f);
            }

            else
                speed.SetValue(this.speed);
        }


    }
}


