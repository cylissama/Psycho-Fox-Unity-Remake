using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class DisplayLives : MonoBehaviour {

    public void LoadGameScene() {
        PlayerManager.Instance.alive = true;
        PlayerManager.Instance.lives -= 1;
        int lives = PlayerManager.Instance.lives;
        print(lives);
        TextMeshPro tmp = GameObject.Find("LivesDisplay").GetComponent<TextMeshPro>() as TextMeshPro;
        tmp.SetText("X" + lives);
        SceneManager.LoadScene("Main Scene");
    }
}
