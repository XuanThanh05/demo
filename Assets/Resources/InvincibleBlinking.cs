using UnityEngine;
using System.Collections;

public class InvincibleBlinking : MonoBehaviour
{
    public float blinkInterval = 0.1f;

    private SpriteRenderer sr;
    private Coroutine blinkCoroutine;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void StartBlink(float duration)
    {
        if (blinkCoroutine != null)
            StopCoroutine(blinkCoroutine);

        blinkCoroutine = StartCoroutine(BlinkRoutine(duration));
    }

    IEnumerator BlinkRoutine(float duration)
    {
        float timer = 0f;

        while (timer < duration)
        {
            sr.enabled = !sr.enabled;
            yield return new WaitForSeconds(blinkInterval);
            timer += blinkInterval;
        }

        sr.enabled = true; // đảm bảo hiện lại
    }
}
