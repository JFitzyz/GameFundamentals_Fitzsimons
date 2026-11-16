using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{

    public GameObject gameOverUI;
    public GameObject mainMenuUI;
    public AudioSource deathAudio;
    public GameObject player;
    public Health health;
    public bool isActive = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
        deathAudio.Play();
        isActive = true;
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void MainMenu()
    {
        gameOverUI.SetActive(false);
        mainMenuUI.SetActive(true);
        Time.timeScale = 1f;
    }
}
