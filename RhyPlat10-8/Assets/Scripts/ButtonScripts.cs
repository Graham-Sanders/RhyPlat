using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScripts : MonoBehaviour
{
    // Update is called once per frame

    public void Button_Use(int scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void Button_exit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
