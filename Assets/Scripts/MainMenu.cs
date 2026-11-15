using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenuUI;
    public GameOverScreen gameOverScreen;
    public GameObject player;
    public Button playButton;
    public Button quitButton;
    public Button optionsButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainMenuUI.SetActive(true);
        gameOverScreen.GetComponent<GameOverScreen>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playGame()
    {
        mainMenuUI.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1.0f;
    }
    public void GameOverRetry(GameOverScreen gameOverScreen)
    {
        mainMenuUI.SetActive(false);
    }

    public void GameOverMainMenu(GameOverScreen gameOverScreen)
    {
        mainMenuUI.SetActive(true);
    }
}
