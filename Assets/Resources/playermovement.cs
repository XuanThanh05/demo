using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Vector3 targetPosition;
    private bool isMoving;

    void Update()
    {
        // Kiểm tra chuột trái
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            isMoving = true;

            Vector3 mousePos = Mouse.current.position.ReadValue();
            mousePos.z = Mathf.Abs(Camera.main.transform.position.z);

            targetPosition = Camera.main.ScreenToWorldPoint(mousePos);
        }
        else
        {
            isMoving = false;
        }

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );
        }
    }
}
