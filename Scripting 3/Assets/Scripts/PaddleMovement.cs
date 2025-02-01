using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    public bool isInverted = false;
    // Update is called once per frame
    void Update()
    {
        if (isInverted)
        {
            var y = 4 - Mathf.PingPong(Time.time, 8);
            var p = gameObject.transform.position;
            p.y = y;
            transform.position = p;
        }
        else
        {
            var y = -4 + Mathf.PingPong(Time.time, 8);
            var p = gameObject.transform.position;
            p.y = y;
            transform.position = p;
        }
    }
}