using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundTileSpawner groundTileSpawner;

    private void Start()
    {
        groundTileSpawner = GameObject.FindObjectOfType<GroundTileSpawner>();
        SpawnObstacle();
        SpawnCoins();
    }

    private void OnTriggerExit(Collider other)
    {
        groundTileSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }


    public GameObject obstacle;
    
    void SpawnObstacle() 
    {

        int obstacleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;
        
 
        Instantiate(obstacle, spawnPoint.position, Quaternion.identity, transform);
    }

    public GameObject coinPrefab;

    void SpawnCoins () 
    {
        int coinsToSpawn = 5;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(coinPrefab,transform);
            temp.transform.position = GetRandomPoint(GetComponent<Collider>());

        }   
    }


    Vector3 GetRandomPoint (Collider collider) {
            Vector3 point = new Vector3(
                Random.Range(collider.bounds.min.x, collider.bounds.max.x),
                Random.Range(collider.bounds.min.y, collider.bounds.max.y),
                Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );

            point.y = 1;
            return point;
        }

}
