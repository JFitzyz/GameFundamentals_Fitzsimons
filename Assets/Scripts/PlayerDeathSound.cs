using UnityEngine;

public class PlayerDeathSound : MonoBehaviour
{
    public GameObject player;
    public GameObject gameOverUI;
    public GameOverScreen gameOverScreen;

    private EnemyDamage enemyDamage;
    public AudioSource deathAudio;
    public Health playerHealth;
    public float soundDelay = 0f;
    public bool hasPlayed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameOverScreen = GetComponent<GameOverScreen>();
        deathAudio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (soundDelay < 1.0f)
        {
            soundDelay += Time.deltaTime;
        }
    }
    public void gameOver()
    {
        
        if (gameOverScreen.isActive == true)
        {
            gameOverScreen.gameOverUI.SetActive(true);
            deathAudio.Play();
            hasPlayed = true;
            Debug.Log("You died lol GGS");
        }
    }
}
