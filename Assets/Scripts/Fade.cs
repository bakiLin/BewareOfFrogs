using DG.Tweening;
using UnityEngine;

public class Fade : MonoBehaviour
{
    [SerializeField] Material[] materials;
    private Tween fadeTween;

    private void Start()
    {
        for (int i = 0; i < materials.Length; i++)
        {
            Color color = materials[i].color;
            color.a = 1f;
            materials[i].color = color;
        }
    }

    private void ObjectFade(float endValue, float duration)
    {
        if (fadeTween != null)
            fadeTween.Kill(false);

        for (int i = 0; i < materials.Length; i++)
            materials[i].DOFade(endValue, duration);
    }

    public void FadeIn(float duration) => ObjectFade(1, duration);

    public void FadeOut(float duration) => ObjectFade(.3f, duration);
}
