using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] Bug;
    int randomIndex;
    Vector3 spawnLoc;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        randomIndex = Random.Range(0, Bug.Length);
        spawnLoc = new Vector3(Random.Range(-2, 3), 5, 0);
    }

    void Spawn()
    {
        Instantiate(Bug[randomIndex], spawnLoc, Bug[randomIndex].transform.rotation);
    }
}
