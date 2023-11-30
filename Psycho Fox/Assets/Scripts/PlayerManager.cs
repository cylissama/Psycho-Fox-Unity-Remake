using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public static PlayerManager Instance { get; private set; }
    public bool alive = true;
    public int lives = 2;
    public float xlocation;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    private float menuTime = 0f;

    private void OnEnable() {
        StartMenuTimer();
    }

    private void OnDisable() {
        StopMenuTimer();
    }

    private void StartMenuTimer() {
        menuTime = 0f;
    }

    private void StopMenuTimer() {
        LogMenuTime();
    }

    void Update() {
        menuTime += Time.deltaTime;
    }

    private void LogMenuTime() {
        Debug.Log("User spent " + menuTime + " seconds in the game.");
    }

    
}
