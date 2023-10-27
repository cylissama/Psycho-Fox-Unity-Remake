using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    private float speed = 0.2f;

    private void OnEnable()  {
        EnemyManager.Instance.addEnemy(this);
    }

    private void OnDisable() {
        EnemyManager.Instance.unaddEnemy(this);
    }

    public void move(Vector3 direction) {
        transform.position += direction * speed * Time.deltaTime;
    }


}
