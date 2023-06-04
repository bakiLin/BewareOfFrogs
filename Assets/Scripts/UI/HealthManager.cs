using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] GameObject[] healthBar = new GameObject[3];
    [SerializeField] GameObject gameOver;
    [SerializeField] Sprite empty;
    
    private int health = 3;

    public void Hit()
    {
        health--;
        healthBar[health].GetComponent<Image>().sprite = empty;

        if (health == 0)
        {
            Time.timeScale = 0f;
            gameOver.SetActive(true);
        }
    }
}
