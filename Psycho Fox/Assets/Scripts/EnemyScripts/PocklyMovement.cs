using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocklyMovement : MonoBehaviour
{
    
    void Update()
    {
        if (PlayerManager.Instance.alive == true) {
            transform.Translate (-0.0005f, 0f, 0f);
        }
        
    }
}
