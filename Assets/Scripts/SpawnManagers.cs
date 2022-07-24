using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagers : MonoBehaviour
{
    public GameObject[] obstacles;
    private float spawnRangeX = 8; 
    private float spawnPosZ = 0; 
    public float spawnPosY = 1.8f; 
    private float startDelay = 2; 
    private float spawnInterval = 1.5f; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle() {
        if (!(GameObject.Find("Player").GetComponent<PlayerController>().isGameOver)) {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ); 
            int prefabIndex = Random.Range(0, obstacles.Length);
            GameObject obstaclePrefab = obstacles[prefabIndex];
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation); 
        }
    
    }

    //  public GameObject[ ] animalPrefabs;
    // private float spawnRangeX = 10; 
    // private float spawnPosZ = 20; 
    // private float startDelay = 2; 
    // private float spawnInterval = 1.5f; 

    // void Start()
    // {
    //   InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);    
    // }

    // // Update is called once per frame
    // void Update()
    // {

        
    // }

    // void SpawnRandomAnimal() { 
    //     Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ); 

    //     int animalIndex = Random.Range(0, animalPrefabs.Length); 

    //     Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    // }

    
}
