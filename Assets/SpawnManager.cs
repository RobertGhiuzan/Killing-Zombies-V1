using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] zombiePrefabs;

    private float spawnPosZ = 95;
    public float startDelay = 2;
    public float spawnInterval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomZombie", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomZombie()
    {
        
        {
            int zombieIndex = Random.Range(0, zombiePrefabs.Length);
            Vector3 spawnPos = new Vector3(87, 14, Random.Range(-spawnPosZ, spawnPosZ));

            Instantiate(zombiePrefabs[zombieIndex], spawnPos, zombiePrefabs[zombieIndex].transform.rotation); 
        }
        
    }
}
