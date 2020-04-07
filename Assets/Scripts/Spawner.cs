using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] bug;
    int randomIndex;
    Vector3 spawnLoc;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 0.5f);

    }

    // Update is called once per frame
    void Update()
    {
        randomIndex = Random.Range(0, bug.Length);
        spawnLoc = new Vector3(Random.Range(-2, 2),5, 0);
    }

    void Spawn()
    {
        Instantiate(bug[randomIndex], spawnLoc, bug[randomIndex].transform.rotation);
    }
}
