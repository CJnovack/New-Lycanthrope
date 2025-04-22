using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] randomPrefab;
    //public int index;
    public GameObject enemyPrefab;
    private float spawnRange = 20;
    private float spawnRangeX = 20;
    private float spawnRangeY = 20;
    private float spawnPosZ = 20;
    private float startDelay = 20;
    private float spawnInterval = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPrefab", startDelay, spawnInterval);
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        
        //Instantiate(randomPrefab, GenerateSpawnPosition(), randomPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY), spawnPosZ);
        int index = Random.Range(0, randomPrefab.Length);
        Instantiate(randomPrefab[index], spawnPos, randomPrefab[index].transform.rotation);
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 20, spawnPosZ);
        return randomPos;
    }

    void SpawnRandomPrefab()
    {
        
        int index = Random.Range(0, randomPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(randomPrefab[index], spawnPos, randomPrefab[index].transform.rotation);
    }
}
