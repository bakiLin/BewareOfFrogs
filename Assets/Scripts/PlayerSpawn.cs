using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    [SerializeField] GameObject player;

    private Vector3 rotation = new Vector3 (-8.75f, 90, 0);

    void Start()
    {
        Vector3 position = transform.position;
        Instantiate(player, position, Quaternion.Euler(rotation), gameObject.transform);

        var camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        camera.GetPlayerPos();
    }
}
