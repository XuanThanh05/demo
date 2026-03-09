using UnityEngine;
using UnityEngine.SceneManagement;
public class BattleFlow : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject gameOverUI;
    public GameObject gameWinUI;
    public GameObject BGMusic;
    void Start()
    {
        gameOverUI.SetActive(false);
        gameWinUI.SetActive(false);
        playerStats.OnDeath += OnGameOver;
    }

    private void OnGameOver()
    {
        gameOverUI.SetActive(true);
        if (BGMusic != null)
            BGMusic.SetActive(false);
    }

    public void OnGameWin()
    {
        gameWinUI.SetActive(true);
        if (BGMusic != null)
            BGMusic.SetActive(false);
    }
    public void BackToMenu()
    {
    SceneManager.LoadScene("MainMenuScence");
    }

}
