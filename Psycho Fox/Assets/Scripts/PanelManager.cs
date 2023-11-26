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
        ShowBootPanel();
    }

    // Function to show the boot panel and hide others
    void ShowBootPanel()
    {
        HideAllPanels();
        bootPanel.SetActive(true);
    }

    // Function to hide all panels
    void HideAllPanels()
    {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
    }

    /*
    // Function to show the initial panel
    void ShowInitialPanel()
    {
        if (isLoggedIn)
        {
            ShowMainPanel();
        }
        else
        {
            ShowLoginPanel();
        }
    }
    */

    // ... (other functions remain the same)

    /*
    // Function to handle register button click (on registration panel)
    public void RegisterButtonOnRegistrationPanelClicked()
    {
        string username = registerUsernameInput.text;
        string password = registerPasswordInput.text;

        // Register user (replace this with your registration logic)
        RegisterUser(username, password);
        isLoggedIn = true;
        loggedInUsername = username;
        ShowMainPanel();
    }

    // Function to switch from login panel to registration panel
    public void SwitchToRegistrationPanel()
    {
        ShowRegistrationPanel();
    }

    // Function to switch from registration panel to login panel
    public void SwitchToLoginPanel()
    {
        ShowLoginPanel();
    }

    // ... (other functions remain the same)
    */

    //Panel activation

    //loginPanel
    public void loginPanelActivate() {
        loginPanel.SetActive(true);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
    }
    
    //registrationPanel
    public void registrationPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(true);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
    }

    //mainPanel
    public void mainPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(true);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(false);
    }

    //scoreboard
    public void scoreboardPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(true);
        bootPanel.SetActive(false);
    }
    

    //bootPanel
    public void bootPanelActivate() {
        loginPanel.SetActive(false);
        registrationPanel.SetActive(false);
        mainPanel.SetActive(false);
        scoreboardPanel.SetActive(false);
        bootPanel.SetActive(true);
    }

}