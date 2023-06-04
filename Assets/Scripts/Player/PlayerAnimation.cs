using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    private Animator animator;

    void Start() 
    {
        animator = GetComponent<Animator>();
    }

    public void Swipe(int num)
    {
        if (num == -1) animator.SetTrigger("isLeft");
        else animator.SetTrigger("isRight");
    }
}
