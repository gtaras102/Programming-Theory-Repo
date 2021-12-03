using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuUIHandler : MonoBehaviour
{
    public Text input;
    public string userName;


    public void EnterName()
    {
        userName = input.text;
        Debug.Log("User name entered.");
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
