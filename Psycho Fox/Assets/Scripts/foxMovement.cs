using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust the speed as needed.
    private Animator anim;
    private SpriteRenderer sprite;
    float horizontalInput;
    public float jumpForce = 0.5f;
    private bool isGrounded;
    private Rigidbody2D rb;
    private void Start()
    {
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get input from the player
        horizontalInput = Input.GetAxis("Horizontal");

        // Calculate the movement vector
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f);

        // Normalize the vector to ensure consistent speed in all directions
        movement.Normalize();

        // Move the player
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            anim.SetBool("isJump", true);
            StartCoroutine(waiter());
        }

        UpdateAnimatorState();

    }

    // this solution is bad but it works for right now
    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.5f);
        anim.SetBool("isJump", false);
    }

    private void UpdateAnimatorState()
    {
        if(horizontalInput > 0f) //moving right
        {
            anim.SetBool("isRunning", true);
            sprite.flipX = false;
        }
        else if (horizontalInput < 0f) //moving left
        {
            anim.SetBool("isRunning", true);
            sprite.flipX = true;
        }
        else //not moving
        {
            anim.SetBool("isRunning", false);
        }
    }
}