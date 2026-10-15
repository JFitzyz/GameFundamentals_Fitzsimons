using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Spawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    public float secondsPassed = 0.0f;
    public float spawnIntervalSeconds = 1.0f;

    InputAction attackAction;

    private void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }
    void Update()
    {
        
        secondsPassed += Time.deltaTime;

        if (secondsPassed > spawnIntervalSeconds && attackAction.IsPressed())
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
            secondsPassed = 0;
        }
    }
}