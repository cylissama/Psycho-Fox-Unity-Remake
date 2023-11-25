using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class foxMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 0.5f;
    public Animator animator;
    private SpriteRenderer sprite;
    public Rigidbody2D rb;
    public float acceleration = 10f;
    public float friction = 5f;
    private Vector2 velocity;
    private bool isMoving;
    private bool isGrounded = true;

    private void Start()
    {

    }

    private void Update() 
    {

        // Get horizontal input from the player
        float horizontalInput = Input.GetAxis("Horizontal");

        if (Mathf.Abs(horizontalInput) > 0.1f) {
            // Start accelerating
            velocity.x += horizontalInput * acceleration * Time.deltaTime;
            isMoving = true;

            // Flip the sprite when moving left
            if (horizontalInput < 0) {
                GetComponent<SpriteRenderer>().flipX = true;
            } else {
                GetComponent<SpriteRenderer>().flipX = false;
            }

        } else {
            // Start decclerating
            velocity.x = Mathf.Lerp(velocity.x, 0f, friction * Time.deltaTime);
            isMoving = false;
        }

        animator.SetFloat("Speed", Mathf.Abs(velocity.x));

        if (isGrounded && Input.GetKeyDown(KeyCode.Space)) {
            rb.AddForce(new Vector2(rb.velocity.x, jumpForce));
            isGrounded = false;
            animator.SetBool("isJump", true);
            StartCoroutine(waiter());
        }
        
    }

    void FixedUpdate() {
    // velocity has to be within -moveSpeed and moveSpeed
    velocity.x = Mathf.Clamp(velocity.x, -moveSpeed, moveSpeed);

    // moves character
    rb.velocity = velocity;
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0.6f);
        isGrounded = true;
        animator.SetBool("isJump", false);
    }

}



















