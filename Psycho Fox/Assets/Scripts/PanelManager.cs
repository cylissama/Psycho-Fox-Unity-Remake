using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;

public class CanvasController : MonoBehaviour
{
    public GameObject loginPanel;
    public GameObject registrationPanel;
    public GameObject mainPanel;
    public GameObject scoreboardPanel;
    public GameObject bootPanel;
    public GameObject completionPanel;

    public InputField loginUsernameInput;
    public InputField loginPasswordInput;
    public InputField registerUsernameInput;
    public InputField registerPasswordInput;
    public Text errorMessageText;
    public Text loggedInUsernameText;

    private string loggedInUsername;
    private bool isLoggedIn = false;
    private List<UserData> scoreboardData = new List<UserData>();

    // Start is called before the first frame update
    void Start()
    {   
        bootPanelActivate();
    }

    // Function to hide all panels
    void HideAllPanels()
    {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
        completionPanel.SetActive(false);
    }

    //Panel activation

    //loginPanel
    public void loginPanelActivate() {
        loginPanel.SetActive(true);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
        completionPanel.SetActive(false);
    }
    
    //registrationPanel
    public void registrationPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(true);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
        completionPanel.SetActive(false);
    }

    //mainPanel
    public void mainPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(true);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
        completionPanel.SetActive(false);
    }

    //scoreboard
    public void scoreboardPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(true);
        bootPanel.SetActive(false);
        completionPanel.SetActive(false);
    }
    

    //bootPanel
    public void bootPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(true);
        completionPanel.SetActive(false);
    }

    //bootPanel
    public void completionPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
        completionPanel.SetActive(true);
    }
}