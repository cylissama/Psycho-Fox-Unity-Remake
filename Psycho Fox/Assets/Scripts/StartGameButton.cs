using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class StartGameButton : MonoBehaviour
{
    public void StartGame()
    {   
        Stopwatch st = new Stopwatch();
        st.Start();
        SceneManager.LoadScene("Main Scene");
        st.Stop();
        UnityEngine.Debug.Log(string.Format ("StartGame took {0} ms to complete", st.ElapsedMilliseconds));
    }
}