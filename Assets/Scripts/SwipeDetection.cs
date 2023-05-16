using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    private PlayerAnimation _animation;
    private PlayerMovement _movement;
    private Vector2 startPos;
    private int pixelDist = 40;
    private bool touch;

    private void Start()
    {
        GameObject player = GameObject.Find("player(Clone)");
        _animation = player.GetComponent<PlayerAnimation>();

        GameObject playerPos = GameObject.Find("Player_Spawn");
        _movement = playerPos.GetComponent<PlayerMovement>();
    }

    void Update()
    {
        if (touch == false && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            touch = true;
        }

        if (touch && Input.touches.Length > 0)
        {
            int line = _movement.GetLine();
            bool onLine = _movement.GetPos();

            if (Input.touches[0].position.x <= startPos.x - pixelDist)
            {
                touch = false;
                if (line != 0 && onLine)
                {
                    _animation.Swipe("left");
                    _movement.Move("left");
                }
            }

            if (Input.touches[0].position.x >= startPos.x + pixelDist)
            {
                touch = false;
                if (line != 2 && onLine)
                {
                    _animation.Swipe("right");
                    _movement.Move("right");
                }  
            }
        }
    }
}
