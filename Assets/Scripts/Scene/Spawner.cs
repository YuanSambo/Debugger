﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] SingleBug;
    public GameObject[] SteadyBug;
    public GameObject[] BossBug;
    public GameObject[] Powerups;
    public FloatVariable multiplier;
    GameObject GameManager;
    AudioSource BossSound;
    float dropRate, dropChance;


    bool BossTime;


    void Start()
    {
        GameManager = GameObject.Find("GameManager");
        BossSound = GetComponent<AudioSource>();
        InvokeRepeating("SpawnSingle", 3f, 3f);
        InvokeRepeating("SpawnSteady", 15, 7f);
        Invoke("SpawnBoss", 30f);
        InvokeRepeating("SpawnPowerUps", 1f, 4f - multiplier.initialValue);
    }

    // Update is called once per frame
    void Update()
    {


        if (BossTime)
        {
            CancelInvoke("SpawnSingle");
            CancelInvoke("SpawnSteady");
            GameManager.GetComponent<AudioSource>().Stop();
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
        BossSound.Play();

    }

    void SpawnPowerUps()
    {
        dropRate = 0.30f;
        dropChance = Random.Range(0f, 1f);

        if (dropChance <= dropRate)
        {
            var randomIndex = Random.Range(0, Powerups.Length);
            var spawnLoc = new Vector3(Random.Range(-2, 3), 6, 0);
            Instantiate(Powerups[randomIndex], spawnLoc, Powerups[randomIndex].transform.rotation);
        }
    }


}
