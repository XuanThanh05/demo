using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.2f;

    private float timer;

    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                Shoot();
                timer = fireRate;
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        Bullet b = bullet.GetComponent<Bullet>();
        b.targetTag = "Enemy";
    }
}
