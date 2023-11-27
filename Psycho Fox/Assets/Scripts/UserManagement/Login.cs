using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Login : MonoBehaviour
{
    public TMP_InputField usernameInput;
    private string username;
    public TMP_InputField passwordInput;
    private string password;
    public GameObject panel;
    private UserInfo ud;

    private void Start() {
        ud = panel.GetComponent<UserInfo>();
    }

    public void loginUser() {

        username = usernameInput.text;
        password = passwordInput.text;
        print("from input field:    " + username + ":" + password);

        foreach (var item in ud.userdata) {
            print("from database:   " + item.Key + ":" + item.Value);
            if (username == item.Key && password == item.Value) {
                print("Successfully logged in " + item.Key);
                return;
            }
        }
        print("User does not exist, you need to register first");
    }
    
}
