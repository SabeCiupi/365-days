using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float spawnInterval = 2f;

    void Start()
    {
        InvokeRepeating("SpawnCube", 0f, spawnInterval);
    }
    
    void SpawnCube()
    {
        Instantiate(cubePrefab, new Vector3(Random.Range(-5f, 5f), 0f, Random.Range(-5f, 5f)), Quaternion.identity);
    }
}
