using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    [SerializeField] GameObject tile;
    [SerializeField] GameObject parent;

    [SerializeField] Vector3 spawnPosition;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            AddTile();

            if (i != 4)
                spawnPosition += new Vector3(2.6f, 0, 0);
        }
    }

    private void AddTile()
    {
        Instantiate(tile, spawnPosition, Quaternion.identity, parent.transform);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Tile")
            AddTile();
    }
}