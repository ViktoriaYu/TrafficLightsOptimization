using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
public class VehicleSpawner : MonoBehaviour
{
    public GameObject[] vehicle;
    public Transform[] spawnPoints;

    private int rand;
    private int randPosition;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;


    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, vehicle.Length);
            randPosition = Random.Range(0, spawnPoints.Length);
            Instantiate(vehicle[rand], spawnPoints[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = startTimeBtwSpawns;
        }   
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
*/


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
