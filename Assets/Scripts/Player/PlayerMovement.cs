using DG.Tweening;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] Vector3[] linePos;
    [SerializeField] float speed;

    private Vector3 rotation = new Vector3(-8.75f, 90, 0);
    private int currentLine = 1;

    void Start()
    {
        Instantiate(player, transform.position, Quaternion.Euler(rotation), gameObject.transform);
    }

    public void Move(int num)
    {
        if (num == -1) currentLine--; else currentLine++;

        transform.DOMove(linePos[currentLine], speed)
            .SetSpeedBased().SetEase(Ease.Linear);
    }

    public int GetLine() => currentLine;
}
