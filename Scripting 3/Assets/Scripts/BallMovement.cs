using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class BallMovement : MonoBehaviour
{
    public float speed = 100f; // Ball speed
    public float bounceForce = 1.1f;
    private Rigidbody2D _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    void LaunchBall()
    {
        float xDirection = Random.Range(0, 2) == 0 ? 1 : -1; // Random left or right
        float yDirection = Random.Range(0, 2) == 0 ? 1 : -1; // Random up or down
        _rb.velocity = new Vector2(xDirection, yDirection) * speed * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Paddle") || collision.gameObject.CompareTag("Border"))
        {
            // Increase ball speed slightly every time it bounces
            _rb.velocity *= bounceForce;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Killzone"))
        {
            _rb.velocity = Vector2.zero;
            transform.position = Vector3.zero;
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            gameObject.GetComponent<ColorChange>().ResetColorChange();
            LaunchBall();
        }
    }
}