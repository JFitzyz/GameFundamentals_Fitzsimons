using UnityEngine;

// NO LONGER IN USE FOR NOW. WAS FOR THE GAME OVER SOUND INITIALLY, HOWEVER MOVED THAT TO GAME OVER UI SCRIPT.
// THIS WILL BE USED FOR DAMAGE TAKEN, POWER UP NOISES, ETC.
// NEEDS TO BE RE-WRITTEN! :)

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
