using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foxController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    //collider functions
    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyManager.Instance.triggerenter(other);
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        EnemyManager.Instance.triggerstay(other);
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        EnemyManager.Instance.triggerexit(other);
    }
}
