using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Button_Play()
    {

    }

    void Button_exit()
    {
        Application.quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
