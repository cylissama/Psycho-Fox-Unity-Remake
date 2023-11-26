using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public Transform player;
    public float cameraSpeed = 15.0f;
    public float maxCameraX;
    public float minCameraX;
    public float maxCameraY;
    public float minCameraY;
    void FixedUpdate() {

        if (player.position.x > transform.position.x) {
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x, minCameraX, maxCameraX);
            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
        }

        if (player.position.y != transform.position.y) {
            Vector3 targetPosition = new Vector3(transform.position.x, player.position.y, transform.position.z);
            targetPosition.y = Mathf.Clamp(targetPosition.y, minCameraY, maxCameraY);
            transform.position = Vector3.Lerp(transform.position, targetPosition, cameraSpeed * Time.deltaTime);
        }
    }
}
