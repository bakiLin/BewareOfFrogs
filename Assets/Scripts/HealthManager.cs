using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] GameObject[] healthBar = new GameObject[3];
    [SerializeField] Sprite healthSprite;
    [SerializeField] GameObject gameOver;

    private int health = 3;

    public void Hit()
    {
        health--;
        healthBar[health].GetComponent<Image>().sprite = healthSprite;

        if (health == 0)
        {
            Time.timeScale = 0f;
            GameOver();
        }
    }

    private void GameOver()
    {
        gameOver.SetActive(true);
    }
}
