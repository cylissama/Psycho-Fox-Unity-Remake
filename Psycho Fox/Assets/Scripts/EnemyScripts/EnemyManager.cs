using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    public GameObject enemyOne;
    public GameObject enemyTwo;

    public GameObject fox;
    private CircleCollider2D colliderObj;

    private List<Enemy> allEnemies = new List<Enemy>();

    

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private void Start() {

        if (fox != null)
        {
            colliderObj = fox.GetComponent<CircleCollider2D>();
        }

        SpawnEnemy(new Vector3(0, 1f, 0), enemyOne);
        SpawnEnemy(new Vector3(0.5f, 1f, 0), enemyTwo);
    }

    void Update() {

    }

    public void addEnemy(Enemy enemy) {
        if (!allEnemies.Contains(enemy))
            allEnemies.Add(enemy);
    }

    public void unaddEnemy(Enemy enemy) {
        if (allEnemies.Contains(enemy))
            allEnemies.Remove(enemy);
    }

    public void SpawnEnemy(Vector3 position, GameObject enemyType)
    {
        GameObject enemyObj = Instantiate(enemyType, position, Quaternion.identity);
        Enemy enemy = enemyObj.GetComponent<Enemy>();
        allEnemies.Add(enemy);
    }

    public void MoveEnemy(GameObject enemyType) {
    
    }

    public void triggerenter(Collider2D other)
    {
        if (other.tag != "Ground") {
            print("You just took damage");
        }
    }


    public void triggerstay(Collider2D other)
    {
        if (other.tag != "Ground") {

        }
    }


    public void triggerexit(Collider2D other)
    {
        if (other.tag != "Ground") {

        }
    }
}
