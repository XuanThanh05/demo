using UnityEngine;

public class showlog : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!");
    }
    void Update()
    {
      Debug.Log("Update called! " + Time.frameCount);
    }
}
