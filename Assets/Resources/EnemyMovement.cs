using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 1f;
    public float endY = -8f;

    void Update()
    {
        Vector3 direction = Vector3.down; // ⬇ đi xuống theo Y

        transform.Translate(direction * speed * Time.deltaTime);

        if (transform.position.y <= endY)
        {
            Destroy(gameObject);
        }
    }
}
