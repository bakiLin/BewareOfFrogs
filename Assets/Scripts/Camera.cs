using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] Transform player;

    private Vector3 offset;

    private void Start()
    {
        offset = player.position - transform.position;
    }

    private void LateUpdate()
    {
        transform.position = player.position - offset;
    }
}
