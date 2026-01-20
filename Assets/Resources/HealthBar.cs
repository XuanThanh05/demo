using UnityEngine;

public class HealthBar : MonoBehaviour
{
    public RectTransform fillRect;

    private Health target;
    private Vector3 offset;
    private float fullWidth;

    private float visibleTimer;
    private const float visibleDuration = 3f;

    public void Setup(Health health)
    {
        target = health;
        offset = new Vector3(0, 0.8f, 0);
        fullWidth = fillRect.sizeDelta.x;

        SetVisible(false); // mặc định ẩn
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject);
            return;
        }

        transform.position = target.transform.position + offset;

        float percent = target.CurrentHealthNormalized;
        fillRect.sizeDelta = new Vector2(fullWidth * percent, fillRect.sizeDelta.y);

        // đếm ngược để ẩn
        if (visibleTimer > 0)
        {
            visibleTimer -= Time.deltaTime;
            if (visibleTimer <= 0)
            {
                SetVisible(false);
            }
        }
    }

    public void Show()
    {
        visibleTimer = visibleDuration;
        SetVisible(true);
    }

    private void SetVisible(bool value)
    {
        gameObject.SetActive(value);
    }
}
