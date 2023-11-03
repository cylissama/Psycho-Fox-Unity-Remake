using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class StartGameButton : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Main Scene");
    }
}
