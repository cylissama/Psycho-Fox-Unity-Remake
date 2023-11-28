using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public  PlayerManager playermanager;
    public float acceleration = 5.0f; // Acceleration rate
    public float deceleration = 5.0f; // Deceleration rate
    public float maxSpeed = 10.0f; // Maximum speed
    public float jumpForce = 10.0f; // Jump force
    public float springForce = 2.5f; // Spring force
    public Transform groundCheck; // Transform to determine if the player is grounded
    public float groundCheckRadius = 0.5f; // Radius for ground check
    public LayerMask groundLayer; // LayerMask to determine what is ground
    public Animator animator;
    private Vector2 currentVelocity; // Current velocity of the object
    private bool isGrounded; // Is the player on the ground?
    private Rigidbody2D rb; // Rigidbody2D component of the object

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playermanager = GameObject.Find("PlayerManager").GetComponent<PlayerManager>() as PlayerManager;
    }

    void Update()
    {
        if (playermanager.alive == true) {
            // Check if the player is grounded
            isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);
            animator.SetBool("isJump", !isGrounded);

            // Get input from horizontal and vertical axes
            float inputX = Input.GetAxis("Horizontal");
            if (inputX > 0f) {
                GetComponent<SpriteRenderer>().flipX = false;
            } else if (inputX < 0f) {
                GetComponent<SpriteRenderer>().flipX = true;
            }
            Vector2 inputDirection = new Vector2(inputX, 0).normalized;

            // Apply acceleration or deceleration
            if (inputDirection != Vector2.zero)
            {
                
                // Accelerate towards the input direction
                currentVelocity += inputDirection * acceleration * Time.deltaTime;
                animator.SetFloat("Speed", Mathf.Abs(inputX));
            }
            else
            {
                // Apply deceleration when no input is given
                if (currentVelocity.magnitude > 0)
                {
                    currentVelocity -= currentVelocity.normalized * deceleration * Time.deltaTime;
                    if (currentVelocity.magnitude < 0.1f) // To stop completely if the speed is very low
                    {
                        currentVelocity = Vector2.zero;
                    }
                }
            }

            // Clamp the velocity to the maximum speed
            currentVelocity = Vector2.ClampMagnitude(currentVelocity, maxSpeed);

            // Apply horizontal movement
            rb.velocity = new Vector2(currentVelocity.x, rb.velocity.y);

            // Jumping
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        } else {
            rb.velocity = new Vector2(0, 0);
        }
    }

    private void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.CompareTag("Spring")) {
            rb.AddForce(Vector2.up * springForce, ForceMode2D.Impulse);
        }
    }
}