using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class FinishGame : MonoBehaviour
{
    [SerializeField]
    private string levelcompletedscene = "Level Completed Screen";
    [SerializeField]
    private string bootscene = "Boot Screen";

    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.name == "RoundEndSign") {
            SceneManager.LoadScene(levelcompletedscene);
            
        }

    }

    

}
