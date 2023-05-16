using DG.Tweening;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Vector3[] linePos = new Vector3[3];
    [SerializeField] float swipeSpeed = 1f;

    private int currentLine = 1;

    public int GetLine() => currentLine;

    public bool GetPos() => transform.position == linePos[currentLine];

    public void Move(string direction)
    {
        int num = 0;
        if (direction == "left") num = -1; else num = 1;

        transform.DOMove(linePos[currentLine + num], swipeSpeed)
            .SetSpeedBased().SetEase(Ease.Linear);
        currentLine += num;
    }
}
