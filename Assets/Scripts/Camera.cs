using UnityEngine;

public class Camera : MonoBehaviour
{
    private GameObject player;
    private Vector3 offset; 

    public void GetPlayerPos()
    {
        player = GameObject.Find("Player_Spawn");
        offset = player.transform.position - transform.position;
    }

    private void LateUpdate()
    {
        if (player != null)
            transform.position = player.transform.position - offset;
    }
}
