using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
     void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "RoundEndSign") {
            print("finish");
            SceneManager.LoadScene("Boot Screen");
        }
    }  
}
