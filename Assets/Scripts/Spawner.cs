using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;


// Declaring a class makes a new type of thing we can instantiate, in this case a type of MonoBehaviour
public class Spawner : MonoBehaviour
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
            secondsPassed = 0;
        }
    }
}