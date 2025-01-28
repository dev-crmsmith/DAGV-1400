using System;
using Unity.VisualScripting;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Vector2 dir = Vector2.right;
    public float force = 5000;

    // Start is called before the first frame update
    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _rb.AddForce(dir * force * Time.deltaTime);
    }
}
