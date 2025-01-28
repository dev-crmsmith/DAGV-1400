using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Collision detected between " + gameObject.name + " and " + other.gameObject.name);
    }
}
