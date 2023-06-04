using System.Collections;
using UnityEngine;

public class EnemyDetect : MonoBehaviour
{
    private HealthManager healthManager;
    private bool hit = false;
    private int hitCount;

    private void Start()
    {
        healthManager = GameObject.Find("Canvas").GetComponent<HealthManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && hit == false)
        {
            hit = true;
            StartCoroutine(Cooldown());
        }
    }

    private IEnumerator Cooldown()
    {
        hitCount++;
        healthManager.Hit();

        if (hitCount != 3)
        {
            var fading = gameObject.GetComponent<Fade>();
            for (int i = 0; i < 5; i++)
            {
                fading.FadeOut(0.3f);
                yield return new WaitForSeconds(0.3f);
                fading.FadeIn(0.3f);
                yield return new WaitForSeconds(0.3f);
            }

            hit = false;
        }
    }
}
