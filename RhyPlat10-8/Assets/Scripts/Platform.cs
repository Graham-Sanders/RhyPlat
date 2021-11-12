using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Platform : MonoBehaviour
{
    Renderer plat;
    // Start is called before the first frame update
    void Start()
    {
        RhythmManager.instance.onBeat.AddListener(OnBeat);
        plat = gameObject.GetComponent<Renderer>();
    }

    public void OnBeat(int beat)
    {
        print(beat);
        if (plat.tag == "green" & beat!=0)
        {
            plat.enabled = false;

        }
        else if(plat.tag == "yellow" & beat == 0)
        {
            
        }
        else if(plat.tag == "blue" & beat %3 == 0)
        {
            plat.enabled = false;
        }
        else
        {
            plat.enabled = true;
        }
    }

}