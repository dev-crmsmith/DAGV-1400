using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipTransformBehaviour : MonoBehaviour
{
    public float directionRight = 0f, directionLeft = 180f;
    
    private void Update()
    {
        var moveInput = Input.GetAxis("Horizontal");
        if (moveInput > 0)
        {
            transform.eulerAngles = new Vector3(0f, directionRight, 0f);
        }
        else if (moveInput < 0)
        {
            transform.eulerAngles = new Vector3(0f, directionLeft, 0f);
        }
    }
}
