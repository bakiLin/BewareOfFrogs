using UnityEngine;

public class DeleteTile : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Tile" || other.tag ==  "Frog")
            Destroy(other.gameObject);
    }
}
