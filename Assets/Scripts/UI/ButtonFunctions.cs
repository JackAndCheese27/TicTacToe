using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public void ExitToDesktop()
        {
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #endif
            Application.Quit();
        }
    
    public void PlayGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }

    public void ExitToTitle()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    
}
