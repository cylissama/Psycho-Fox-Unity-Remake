using UnityEngine;
using UnityEngine.SceneManagement;
using System.Diagnostics;


public class BackToMain : MonoBehaviour
{
    public void BackToMainScreen()
    { 
        Stopwatch st = new Stopwatch();
        st.Start();
        SceneManager.LoadScene("Boot Screen");
        st.Stop();
        UnityEngine.Debug.Log(string.Format ("BackToMain took {0} ms to complete", st.ElapsedMilliseconds));
    }
}
