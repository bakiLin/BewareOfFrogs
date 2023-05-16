using Unity.VisualScripting;
using UnityEngine;

public class TileMovement : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Vector3 toPosition = new Vector3(-2f, 0, 0);

    private Vector3 tileSpeed;

    private void Update()
    {
        tileSpeed = velocity * toPosition * Time.deltaTime;
        transform.Translate(tileSpeed, Space.World);

        if (transform.position.x < -2f)
            Destroy(gameObject);
    }
}
