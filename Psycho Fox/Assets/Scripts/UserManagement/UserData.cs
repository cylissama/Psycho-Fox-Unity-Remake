using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInfo : MonoBehaviour
{
    public IDictionary<string, string> userdata = new Dictionary<string, string>();
    public TMP_InputField usernameInput;
    private string username;
    public TMP_InputField passwordInput;
    private string password;
    

    public void registerUser() {
        username = usernameInput.text;
        password = passwordInput.text;
        userdata[username] = password;
        print("Successfully registerd " + username);
    }

    public void UpdateHighScore() {

    }
}
