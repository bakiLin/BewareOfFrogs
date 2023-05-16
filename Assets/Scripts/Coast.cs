using UnityEngine;

public class Coast : MonoBehaviour
{
    [SerializeField] GameObject tile;
    [SerializeField] Vector3 spawnPos;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            AddTile();
            spawnPos += new Vector3(2.6f, 0, 0);
        }

        spawnPos -= new Vector3(2.6f, 0, 0);
    }

    private void AddTile()
    {
        Instantiate(tile, spawnPos, Quaternion.identity, gameObject.transform);
    }

    private void OnEnable() => TileSpawn.onCoastSpawn += AddTile;

    private void OnDisable() => TileSpawn.onCoastSpawn -= AddTile;
}
