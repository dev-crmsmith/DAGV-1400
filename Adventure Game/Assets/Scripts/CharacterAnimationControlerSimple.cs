using UnityEngine;

public class CharacterAnimationControlerSimple : MonoBehaviour
{
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
        // Triggers the Double Jump animation
        if (Input.GetButtonDown("Jump"))
        {
            _animator.SetTrigger("DoubleJumpTrigger");
        }
        else
        {
            _animator.SetTrigger("IdleTrigger");
        }
        
        // Triggers the Hit animation
        if (Input.GetKeyDown(KeyCode.H))
        {
            _animator.SetTrigger("HitTrigger");
        }
        else
        {
            _animator.SetTrigger("IdleTrigger");
        }
        
        // Triggers the Fall animation
        if (Input.GetKeyDown(KeyCode.F))
        {
            _animator.SetTrigger("FallTrigger");
        }
        else
        {
            _animator.SetTrigger("IdleTrigger");
        }
    }
}
