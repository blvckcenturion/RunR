using UnityEngine;

public class GroundTileSpawner : MonoBehaviour
{
    public GameObject groundTile;
    Vector3 nextSpawnPosition;
    

    public void SpawnTile ()
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPosition, Quaternion.identity);
        nextSpawnPosition = temp.transform.GetChild(1).transform.position;
    }

    void Start()
    {
        for (int i = 0; i < 15; i++){
            SpawnTile();
        }
    }
}
