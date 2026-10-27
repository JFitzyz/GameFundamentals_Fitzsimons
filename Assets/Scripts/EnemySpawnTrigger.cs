using UnityEngine;

public class EnemySpawnTrigger : MonoBehaviour
{

    public Spawner spawner;
    void Start()
    {
        spawner = GetComponent<Spawner>();
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerCharacterControls player = collision.GetComponent<PlayerCharacterControls>();

        if(player != null)
        {
            spawner.isSpawning = true;
        }
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerCharacterControls player = collision.GetComponent<PlayerCharacterControls>();
        if (player != null)
        {
            spawner.isSpawning = false;
        }
    }
}