using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Button_Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Button_exit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
