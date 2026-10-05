using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{

    public GameObject prefabToSpawn;
    InputAction attackAction;
    int cooldownFrames = 0;
    public float timeBetweenSpawn = 1.0f;
    public float timeSinceLastSpawn = 0.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        attackAction = InputSystem.actions.FindAction("Attack");
    }

    // Update is called once per frame
    void Update()
    {
        if(attackAction.IsPressed() && timeSinceLastSpawn > timeBetweenSpawn)
        {
            Instantiate(prefabToSpawn, transform.position, transform.rotation);
            cooldownFrames = 0;
        }
        timeSinceLastSpawn += Time.deltaTime;
    }
}
