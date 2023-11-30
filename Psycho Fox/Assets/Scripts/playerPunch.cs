using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPunch : MonoBehaviour
{
    public Animator animator;
    public GameObject hitbox;

    void Start() {
        hitbox.GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) | Input.GetKeyDown("x")) {
            animator.SetTrigger("Punch");
        }
    }

    public void EnableCol() {
        hitbox.GetComponent<BoxCollider2D>().enabled = true;
    }

    public void DisableCol() {
        hitbox.GetComponent<BoxCollider2D>().enabled = false;
    }
}
