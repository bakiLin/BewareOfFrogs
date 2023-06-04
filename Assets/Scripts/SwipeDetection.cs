using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    private PlayerAnimation playerAnimation;
    private PlayerMovement playerMovement;

    private Vector2 start;
    private int currentLine = 1;
    private bool touch;

    private void Start()
    {
        GameObject player = GameObject.Find("Player(Clone)");
        playerAnimation = player.GetComponent<PlayerAnimation>();

        GameObject playerPos = GameObject.Find("Player_Spawn");
        playerMovement = playerPos.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (touch == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            start = Input.touches[0].position;
            touch = true;
        }

        if (touch && Input.touches.Length > 0)
        {
            if (Input.touches[0].position.x <= start.x - 40)    //pixel distance
            {
                touch = false;
                if (currentLine != 0)
                    Turn(-1);
            }

            if (Input.touches[0].position.x >= start.x + 40)    //pixel distance
            {
                touch = false;
                if (currentLine != 2)
                    Turn(1);
            }
        }
    }

    private void Turn(int num)
    {
        currentLine += num;
        playerAnimation.Swipe(num);
        playerMovement.Move(num);
    }
}