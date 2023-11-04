using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

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
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        EnemyManager.Instance.triggerenter(other);
        stopwatch.Stop();
        UnityEngine.Debug.Log("TriggerEnter took " + stopwatch.ElapsedMilliseconds + "ms to complete");
    }


    private void OnTriggerStay2D(Collider2D other)
    {
        EnemyManager.Instance.triggerstay(other);
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        EnemyManager.Instance.triggerexit(other);
        stopwatch.Stop();
        UnityEngine.Debug.Log("TriggerExit took " + stopwatch.ElapsedMilliseconds + "ms to complete");
    }
}
