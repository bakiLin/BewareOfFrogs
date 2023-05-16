using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject healthBarUI;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] GameObject startMenuUI;
    [SerializeField] GameObject swipeDetector;

    private void Start()
    {
        Time.timeScale = 0f;
        startMenuUI.SetActive(true);
        gameOverUI.SetActive(false);
        healthBarUI.SetActive(false);
        swipeDetector.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        healthBarUI.SetActive(true);
        swipeDetector.SetActive(true);
        startMenuUI.SetActive(false);
    }

    public void Quit() => Application.Quit();

    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
