using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuScript : MonoBehaviour
{
    GlobalVariablesScript globalVars;
    void Start()
    {
        globalVars = GameObject.Find("GlobalVariables").GetComponent<GlobalVariablesScript>();
    }

    void Update()
    {
        
    }

    public void StartGameButton()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitGameButton()
    {
        Application.Quit(0);
    }
    public void OptionsMenuButton()
    {
        SceneManager.LoadScene(2);
    }
}
