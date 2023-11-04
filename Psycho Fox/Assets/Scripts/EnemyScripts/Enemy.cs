using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Diagnostics;

public class Enemy : MonoBehaviour
{   
    private float speed = 0.2f;

    private void OnEnable()  {

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        EnemyManager.Instance.addEnemy(this);
        stopwatch.Stop();
        UnityEngine.Debug.Log("addEnemy took " + stopwatch.ElapsedMilliseconds + "ms to complete");
    }

    private void OnDisable() {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        EnemyManager.Instance.unaddEnemy(this);
        stopwatch.Stop();
        UnityEngine.Debug.Log("unaddEnemy took " + stopwatch.ElapsedMilliseconds + "ms to complete");
    }

    public void move(Vector3 direction) {
        transform.position += direction * speed * Time.deltaTime;
    }


}
