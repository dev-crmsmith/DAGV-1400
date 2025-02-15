using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private int _jumpCount = 0;
    private Animator _animator;
    private void Start()
    {
        // Cache the animator component attached to CharacterArt
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
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
            if (_jumpCount == 0)
            {
                _animator.SetTrigger("Jump");
            }
            else if (_jumpCount == 1)
            {
                _animator.SetTrigger("DoubleJump");
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
