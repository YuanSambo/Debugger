using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] SingleBug;
    public GameObject[] SteadyBug;
    public GameObject[] BossBug;
    public GameObject[] Powerups;
    float dropRate, dropChance;


    bool BossTime;


    void Start()
    {
        InvokeRepeating("SpawnSingle", 1f, 1f);
        InvokeRepeating("SpawnSteady", 15, 5f);
        Invoke("SpawnBoss", 30f);
        InvokeRepeating("SpawnPowerUps", 1f, 4f);
    }

    // Update is called once per frame
    void Update()
    {


        if (BossTime)
        {
            CancelInvoke("SpawnSingle");
            CancelInvoke("SpawnSteady");
        }

    }



    void SpawnSingle()
    {
        var randomIndex = Random.Range(0, SingleBug.Length);
        var spawnLoc = new Vector3(Random.Range(-2, 3), 6, 0);
        Instantiate(SingleBug[randomIndex], spawnLoc, SingleBug[randomIndex].transform.rotation);

    }

    void SpawnSteady()
    {
        var randomIndex = Random.Range(0, SteadyBug.Length);
        for (int i = -2; i < 3; i++)
        {
            Instantiate(SteadyBug[randomIndex], new Vector3(i, 6, 0), SteadyBug[randomIndex].transform.rotation);

        }


    }

    void SpawnBoss()
    {
        var randomIndex = Random.Range(0, BossBug.Length);
        Instantiate(BossBug[randomIndex], new Vector3(0, 6, 0), BossBug[randomIndex].transform.rotation);
        BossTime = true;
    }

    void SpawnPowerUps()
    {
        dropRate = 0.30f;
        dropChance = Random.Range(0f, 1f);
        Debug.Log(dropChance);

        if (dropChance <= dropRate)
        {
            var randomIndex = Random.Range(0, SingleBug.Length);
            var spawnLoc = new Vector3(Random.Range(-2, 3), 6, 0);
            Instantiate(Powerups[randomIndex], spawnLoc, Powerups[randomIndex].transform.rotation);
        }
    }

}
