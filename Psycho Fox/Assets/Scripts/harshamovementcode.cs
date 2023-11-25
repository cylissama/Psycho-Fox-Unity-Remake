using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class harshamovementcode : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f; // Adjust the jumpForce value as needed.
    public Animator animator;
    private SpriteRenderer sprite;
    public Rigidbody2D rb;
    private bool isGrounded = true;

    private void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        // Get horizontal input from the player
        float horizontalInput = Input.GetAxis("Horizontal");

        // Move the character horizontally
        rb.velocity = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        // Flip the sprite when moving left
        if (horizontalInput < 0)
        {
            sprite.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            sprite.flipX = false;
        }

        // Check if the character can jump
        if (isGrounded)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);
                isGrounded = false;
                animator.SetBool("isJump", true);
                StartCoroutine(waiter());
            }
        }

        // Check for button clicks
        if (Input.GetButtonDown("MoveLeft"))
        {
            // Move left button click
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
            sprite.flipX = true; // Flip the sprite when moving left
            animator.SetBool("isRunning", true); // Play the running animation
        }
        else if (Input.GetButtonDown("MoveRight"))
        {
            // Move right button click
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
            sprite.flipX = false; // Flip the sprite when moving right
            animator.SetBool("isRunning", true); // Play the running animation
        }
        else if (!Input.GetButton("MoveLeft") && !Input.GetButton("MoveRight"))
        {
            // If no buttons are pressed, stop the character
            rb.velocity = new Vector2(0f, rb.velocity.y);
            animator.SetBool("isRunning", false); // Stop the running animation
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Check if the character is grounded
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            animator.SetBool("isJump", false);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.6f);
        isGrounded = true;
        animator.SetBool("isJump", false);
    }
}