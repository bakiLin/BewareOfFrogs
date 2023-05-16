using UnityEngine;

public class Swamp : MonoBehaviour
{
    [SerializeField] GameObject tile;
    [SerializeField] Vector3 rotation;
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
        Instantiate(tile, spawnPos, Quaternion.Euler(rotation), gameObject.transform);
    }

    private void OnEnable() => TileSpawn.onSwampSpawn += AddTile;

    private void OnDisable() => TileSpawn.onSwampSpawn -= AddTile;
}
