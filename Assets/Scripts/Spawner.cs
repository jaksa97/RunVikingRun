using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] enemyPatterns;

    private float spawningTime;
    public float intervalOfSpawning = 1.25f;
    public float frequencyOfSpawning = 0.05f;
    public float minTime = 0.65f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawningTime <= 0)
        {
            int random = Random.Range(0, enemyPatterns.Length);
            Instantiate(enemyPatterns[random], transform.position, Quaternion.identity);
            spawningTime = intervalOfSpawning;
            if (intervalOfSpawning > minTime)
            {
                intervalOfSpawning -= frequencyOfSpawning;
            }
        } else 
        {
            spawningTime -= Time.deltaTime;
        }
    }
}
