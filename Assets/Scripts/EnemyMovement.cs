using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private Animator animator;
    private float jumpStart;

    void Start()
    {
        animator = GetComponent<Animator>();
        StartCoroutine(Jump());
    }

    private IEnumerator Jump()
    {
        while (true) 
        {
            int interval = Random.Range(1, 4);
            yield return new WaitForSeconds(interval);
            animator.SetTrigger("isJumping");
        }
    }

    public void StartJump() => jumpStart = Time.realtimeSinceStartup;
    
    public void EndJump()
    {
        float timer = Time.realtimeSinceStartup - jumpStart;
        transform.position += new Vector3(-timer, 0, 0);
    }
}
