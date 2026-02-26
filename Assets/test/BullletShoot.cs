using UnityEngine;

public class BullletShoot : MonoBehaviour
{
    
    void Update()
    {
        var newPosition = transform.position;
        newPosition.y += Time.deltaTime * 5;
        transform.position = newPosition;
                
    }
}
