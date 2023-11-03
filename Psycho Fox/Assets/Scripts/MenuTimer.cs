using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuTimer : MonoBehaviour
{
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
        Debug.Log("User spent " + menuTime + " seconds in the menu.");
    }
}
