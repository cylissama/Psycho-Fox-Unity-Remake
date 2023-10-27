using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public static EnemyManager Instance { get; private set; }

    public GameObject enemyPrefab;

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
        SpawnEnemy(new Vector3(0, -0.13f, 0));
    }

    void Update() {
        MoveEnemies(Vector3.left); 
    }

    public void addEnemy(Enemy enemy) {
        if (!allEnemies.Contains(enemy))
            allEnemies.Add(enemy);
    }

    public void unaddEnemy(Enemy enemy) {
        if (allEnemies.Contains(enemy))
            allEnemies.Remove(enemy);
    }

    public void SpawnEnemy(Vector3 position)
    {
        GameObject enemyObj = Instantiate(enemyPrefab, position, Quaternion.identity);
        Enemy enemy = enemyObj.GetComponent<Enemy>();
        allEnemies.Add(enemy);
    }

    public void MoveEnemies(Vector3 direction) {
        foreach (Enemy enemy in allEnemies) {
            enemy.move(direction);
        }
    }
}
