using System.Collections;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] Vector3[] linePos;
    [SerializeField] Vector3 rotation;
    [SerializeField] float intervalSec;

    void Start()
    {
        StartCoroutine(Spawner());
    }

    private IEnumerator Spawner()
    {
        int last = 0, current = 0;
        while (true)
        {
            yield return new WaitForSeconds(intervalSec);
            while (last == current) current = Random.Range(0, 3);
            Instantiate(enemy, linePos[current], Quaternion.Euler(rotation), gameObject.transform);
            last = current;
        }
    }
}
