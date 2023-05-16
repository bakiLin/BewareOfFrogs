using System.Collections;
using UnityEngine;

public class FrogSpawn : MonoBehaviour
{
    [SerializeField] GameObject frog;
    [SerializeField] Vector3[] linePos = new Vector3[3];
    [SerializeField] Vector3 rotation;
    [SerializeField] float intervalSec = 2f;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        int last = 0, current = 0;
        while (true)
        {
            while (last == current) current = Random.Range(0, 3);
            yield return new WaitForSeconds(intervalSec);
            Instantiate(frog, linePos[current], Quaternion.Euler(rotation), gameObject.transform);
            last = current;
        }
    }
}
