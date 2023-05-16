using System.Collections;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{
    private HealthManager healthManager;
    private bool hit = false;
    //private int hitCount = 2;

    private void Start()
    {
        healthManager = GameObject.Find("Canvas").GetComponent<HealthManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Frog" && hit == false)
        {
            hit = true;
            StartCoroutine(Cooldown());
        }
    }

    private IEnumerator Cooldown()
    {
        healthManager.Hit();
        var fading = gameObject.GetComponent<Fade>();
        for (int i = 0; i < 2; i++)
        {
            fading.FadeOut(0.75f);
            yield return new WaitForSeconds(0.75f);
            fading.FadeIn(0.75f);
            yield return new WaitForSeconds(0.75f);
        }
        hit = false;
    }
}
