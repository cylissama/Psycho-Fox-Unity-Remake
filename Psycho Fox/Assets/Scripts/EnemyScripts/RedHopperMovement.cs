using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHopperMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 velocity;
    public float jumpForce;
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius = 0.5f;
    public LayerMask groundLayer;
    public Animator animator;
    public bool crouched;

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (isGrounded) {
            animator.SetBool("isJumping", false);
            crouched = true;
        }
        
    }

    public void Jump() {

        if (crouched) {
            crouched = false;
            animator.SetBool("isJumping", true);
            if (PlayerManager.Instance.xlocation < transform.position.x) {
                rb.velocity = new Vector2(-0.1f, rb.velocity.y);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            } else {
                rb.velocity = new Vector2(0.1f, rb.velocity.y);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }
        
    }

}
