using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHopperMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    private bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    [SerializeField] Vector2 boxsize;
    public float relPos;
    public GameObject bro;

    void FixedUpdate()
    {
        if (PlayerManager.Instance.alive && (PlayerManager.Instance.xlocation - transform.position.x > -2f)) {
            isGrounded = Physics2D.OverlapBox(groundCheck.position, boxsize, 0, groundLayer);
            if (isGrounded) {
                Jump();
            }
        } else if (!PlayerManager.Instance.alive){
            Destroy(bro);
        }
        
        
    }

    public void Jump() {
            
            if (PlayerManager.Instance.xlocation < transform.position.x) {
                relPos = -0.0008f;
            } else {
                relPos = 0.0008f;
            }

                rb.AddForce(new Vector2(relPos, jumpForce), ForceMode2D.Impulse);
    }
        
}

