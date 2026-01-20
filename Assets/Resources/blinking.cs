using UnityEngine;
using UnityEngine.InputSystem;

public class blinking : MonoBehaviour
{
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Mouse.current != null)
        {
            sr.enabled = Mouse.current.leftButton.isPressed;
        }
    }
}
