using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour // Class declaration
{
    public GameObject prefabToSpawn;
    public float secondsPassed = 0.0f;
    public float spawnIntervalSeconds = 1.0f;
    public bool isSpawning = true;

    void Update()
    {
        secondsPassed += Time.deltaTime;

        if (secondsPassed > spawnIntervalSeconds && isSpawning)
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
            secondsPassed = 0f;
        }
    }
}