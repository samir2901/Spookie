using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] obstaclePattern;
    public float starttimeBtwSpawn;
    private float timeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int randIndex = Random.Range(0, obstaclePattern.Length);
            //create obstacle
            Instantiate(obstaclePattern[randIndex], transform.position, Quaternion.identity);
            timeBtwSpawn = starttimeBtwSpawn;
            if(starttimeBtwSpawn > minTime)
            {
                starttimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
