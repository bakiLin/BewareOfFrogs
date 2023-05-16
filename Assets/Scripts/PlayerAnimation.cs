using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Swipe(string direction)
    {
        if (direction == "left")
            animator.SetTrigger("isLeft");
        if (direction == "right")
            animator.SetTrigger("isRight");
    }
}
