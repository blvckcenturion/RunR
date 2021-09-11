using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundTileSpawner groundTileSpawner;
    // Start is called before the first frame update
    private void Start()
    {
        groundTileSpawner = GameObject.FindObjectOfType<GroundTileSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundTileSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameObject obstacle;
    
    void SpawnObstacle() 
    {
        //Choose a random point to spawn obstacle
        int obstacleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
        //Spawn the obstacle at the position
        Instantiate(obstacle, spawnPoint.position, Quaternion.identity, transform);
    }

}
