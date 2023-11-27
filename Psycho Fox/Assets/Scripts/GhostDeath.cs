using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GhostDeath : MonoBehaviour
{
    public void LoadMainMenu() {
        SceneManager.LoadScene("Lives");
    }
}
