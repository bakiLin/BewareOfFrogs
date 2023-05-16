using System;
using UnityEngine;

public class TileSpawn : MonoBehaviour
{
    public static Action onSwampSpawn;
    public static Action onCoastSpawn;

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Swamp")
        {
            onSwampSpawn?.Invoke();
        }

        if (other.tag == "Coast")
        {
            onCoastSpawn?.Invoke();
        }
    }
}
