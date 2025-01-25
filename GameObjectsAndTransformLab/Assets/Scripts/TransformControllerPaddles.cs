using UnityEngine;

public class TransformControllerPaddles : MonoBehaviour
{
    private bool _firstPass;
    private void Start()
    {
        _firstPass = true;
    }

    private void Update()
    {
        // Move the Paddles up and down full field, starting at center
        var y = 0.0f;
        if (_firstPass)
        {
            y = Mathf.PingPong(Time.time, 4);
            if (y == 4) _firstPass = false;
        }
        else
        {
            y = -8 + Mathf.PingPong(Time.time, 8);
        }
        var p = new Vector3(0, y, 0);
        transform.position = p;
    }
}
