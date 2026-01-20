using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float speed = 0.5f;
    private float height;

    void Start()
    {
        height = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        // Trượt xuống
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // Nếu đi hết màn hình → nhảy lên trên
        if (transform.position.y <= -height)
        {
            transform.position += Vector3.up * height * 2f;
        }
    }
}
