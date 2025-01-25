using UnityEngine;
public class TransformControllerBall : MonoBehaviour
{
    private void Update()
    {
        // Move the target GameObject
        var x = -10.15f + Mathf.PingPong(Time.time, 20.3f);
        var p = new Vector3(x, 0, 0);
        transform.position = p;
    }
}