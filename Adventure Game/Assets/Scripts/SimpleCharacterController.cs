using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 8f;
    public float gravity = -9.91f;

    private CharacterController _controller;
    private Vector3 _velocity = Vector3.zero;
    private Transform _thisTransform;
    private int _jumpCount = 0;
    void Start()
    {
        _controller = GetComponent<CharacterController>();
        _thisTransform = transform;
    }

    void Update()
    {
        MoveCharacter();
        ApplyGravity();
        KeepCharacterOn2DAxis();
    }

    private void MoveCharacter()
    {
        var moveInput = Input.GetAxis("Horizontal");
        var move = new Vector3(moveInput, 0f, 0f) * (moveSpeed * Time.deltaTime);
        _controller.Move(move);
        
        if (Input.GetButtonDown("Jump") && _jumpCount < 2)
        {
            _jumpCount++;
            _velocity.y = Mathf.Sqrt(jumpForce * -2 * gravity);
        }
    }

    private void ApplyGravity()
    {
        if (!_controller.isGrounded)
        {
            _velocity.y += gravity * Time.deltaTime;
        }
        else
        {
            _velocity.y = 0f;
            _jumpCount = 0;
        }

        _controller.Move(_velocity * Time.deltaTime);
    }

    private void KeepCharacterOn2DAxis()
    {
        // Prevent the character from moving on the z axis
        var currentPosition = _thisTransform.position;
        currentPosition.z = 0f;
        _thisTransform.position = currentPosition;
    }
}
