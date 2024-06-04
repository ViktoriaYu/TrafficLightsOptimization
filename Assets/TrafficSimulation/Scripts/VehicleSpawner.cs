using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehicles;
    public Transform[] spawnPoints;

    private int randVehicle;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;
    public int maxCountOfSpawns;
    private int countOfSpawns;


    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
        countOfSpawns = 0;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0 && countOfSpawns < maxCountOfSpawns)
        {
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                randVehicle = Random.Range(0, vehicles.Length);
                Instantiate(vehicles[randVehicle], spawnPoints[i].transform.position, Quaternion.identity);
            }
            timeBtwSpawns = startTimeBtwSpawns;
            countOfSpawns += 1;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
