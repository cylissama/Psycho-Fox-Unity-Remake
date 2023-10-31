using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFocusedMovement : MonoBehaviour {
    
    public Transform target;
    public float angle;
    public float RotationX = .5f;
    public float rightLeftSpeed = 5f;

    public float currentZoom = 5f;
    public float minZoom = 2f;
    public float maxZoom = 8f;
    public float speedZoom = .5f;

    public float currentHeight = 6f;
    public float minHeight = 3f;
    public float maxHeight = 7f;
    public float speedHeight = 1f;

    void Update() {
        currentZoom -= Input.GetAxis("Mouse ScrollWheel") * speedZoom * Time.deltaTime * 60f;
        currentZoom = Mathf.Clamp(currentZoom, minZoom, maxZoom);
        currentHeight += Input.GetAxis("Vertical") * speedHeight * Time.deltaTime * 60f;
        currentHeight = Mathf.Clamp(currentHeight, minHeight, maxHeight);
        angle -= Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime * 60f;
    }

    void LateUpdate() {
        var newPosition = target.position - (target.forward * currentZoom) + Vector3.up;
        newPosition.y = target.position.y + currentHeight;
        transform.position = newPosition;
        transform.RotateAround(target.position, Vector3.up, angle);
        transform.LookAt(target.position + Vector3.up * RotationX);
    }
}

