using UnityEngine;

public class ShrinkOnCollision : MonoBehaviour
{
    public float shrinkFactor = 0.9f;

    private void OnCollisionExit2D(Collision2D other)
    {
        transform.localScale *= shrinkFactor;
    }
}
