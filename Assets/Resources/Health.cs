using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    private int currentHealth;

    public GameObject explosionPrefab;
    private HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public float CurrentHealthNormalized
    {
        get { return (float)currentHealth / maxHealth; }
    }

    public void SetHealthBar(HealthBar bar)
    {
        healthBar = bar;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (healthBar != null)
            healthBar.Show(); // 👈 hiện thanh máu 3s

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        if (explosionPrefab != null)
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
