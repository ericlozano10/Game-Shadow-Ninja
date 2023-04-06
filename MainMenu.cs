using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    public void PLayGame()
    {
        SceneManager.LoadScene("level 1");

    }
    public void PlayLevel2()
    {
        SceneManager.LoadScene("level 2");
    }
    public void Playlevel3()
    {
        SceneManager.LoadScene("level3");
    }
    public void ClickExit()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
