using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float velocity;
    [SerializeField] Vector3 toPosition;

    private Vector3 speed;

    private void Update() => speed = velocity * toPosition;

    private void FixedUpdate() => transform.Translate(speed * Time.fixedDeltaTime, Space.World);
}