using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPunch : MonoBehaviour
{
    public Animator animator;
    private bool punching = false;


    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            animator.SetTrigger("Punch");
        }
    }
}
