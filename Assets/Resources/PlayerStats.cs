using UnityEngine;
public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 5;
    public int bombs = 3;

    private int currentHealth;
    private PlayerHUD hud;
    public GameObject explosionPrefab;

    private bool isInvincible;
    private InvincibleBlinking blinking;

    void Start()
    {
        currentHealth = maxHealth;
        hud = FindObjectOfType<PlayerHUD>();
        blinking = GetComponent<InvincibleBlinking>();

        hud.UpdateHearts(currentHealth);
        hud.UpdateBombs(bombs);
    }

    public void TakeDamage(int damage)
    {
        if (isInvincible) return; // 👈 bất tử

        currentHealth -= damage;
        hud.UpdateHearts(currentHealth);

        isInvincible = true;
        blinking.StartBlink(3f);
        Invoke(nameof(EndInvincible), 3f);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void EndInvincible()
    {
        isInvincible = false;
    }

    void Die()
    {
        if (explosionPrefab != null)
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        Destroy(gameObject);
    }
}
