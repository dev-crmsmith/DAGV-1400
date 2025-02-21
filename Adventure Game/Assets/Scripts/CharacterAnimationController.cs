using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private int _jumpCount = 0;
    private Animator _animator;
    private CharacterController _controller;
    private Vector3 _velocity = Vector3.zero;
    private void Start()
    {
        // Cache the animator component attached to CharacterArt
        _animator = GetComponent<Animator>();
        _controller = transform.parent.GetComponent<CharacterController>();
    }

    private void Update()
    {
        _velocity = _controller.velocity;
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        // Handle running and idling animations
        if (Input.GetAxis("Horizontal") != 0)
        {
            _animator.SetTrigger("Run");
        }
        else
        {
            _animator.SetTrigger("Idle");
        }
        
        // Handle jumping animation
        if (Input.GetButtonDown("Jump"))
        {
            if (_controller.isGrounded)
            {
                _animator.SetTrigger("Jump");
            }
            else
            {
                _animator.SetTrigger("DoubleJump");
            }
        }
        
        if (!_controller.isGrounded)
        {
            if (_velocity.y < 0)
            {
                _animator.SetTrigger("Fall");
            }
        }
        
        // Handle wall jumping animation
        /* Will switch to this method once collision with wall detection is implemented
         if (Input.GetButtonDown("Jump") && Input.GetAxis("Horizontal") != 0)
        {
            _animator.SetTrigger("WallJump");
        }
        */
        if (Input.GetKeyDown(KeyCode.W))
        {
            _animator.SetTrigger("WallJump");
        }
    }
}
