using UnityEngine;

public class HealthBarSpawner : MonoBehaviour
{
    public GameObject healthBarPrefab;
    private HealthBar healthBar;

    void Start()
    {
        Health health = GetComponent<Health>();
        GameObject bar = Instantiate(healthBarPrefab);
        healthBar = bar.GetComponent<HealthBar>();
        healthBar.Setup(health);

        // gán ngược lại cho Health
        health.SetHealthBar(healthBar);
    }
}
