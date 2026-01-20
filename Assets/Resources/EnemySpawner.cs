using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Danh sách enemy prefab, kéo vào trong Inspector
    public GameObject[] enemy;
    Quaternion rot = Quaternion.Euler(0f, 0f, 180f);

    private void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        Vector3[] spawnPos =
        {
            new Vector3(-3.8f, 5f, 0f),
            new Vector3(-3f, 5f, 0f),
            new Vector3(-1f, 5f, 0f),
            new Vector3(-0.1f, 5f, 0f)
        };

        // Wave 1
        foreach (var pos in spawnPos)
            Instantiate(enemy[0], pos, rot);

        yield return new WaitForSeconds(10f);

        // Wave 2
        foreach (var pos in spawnPos)
            Instantiate(enemy[1], pos, rot);
    }

}
