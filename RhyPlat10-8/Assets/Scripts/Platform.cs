using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Platform : MonoBehaviour
{
    Renderer plat;
    Collider2D physPlat;
    private int counter = 0;
    // Start is called before the first frame update
    void Start()
    {
        RhythmManager.instance.onBeat.AddListener(OnBeat);
        plat = gameObject.GetComponent<Renderer>();
        physPlat = gameObject.GetComponent<Collider2D>();
    }

    public void OnBeat(int beat)
    {
        print(beat);
        if (plat.tag == "green" & beat != 0)
        {
            plat.enabled = false;
            physPlat.enabled = false;
            counter++;
        }
        else if (plat.tag == "yellow" & counter == 3)
        {
            plat.enabled = false;
            physPlat.enabled = false;
            counter = 0;
        }
        else if (plat.tag == "blue" & beat % 3 == 0)
        {
            plat.enabled = false;
            physPlat.enabled = false;
            counter++;
        }
        else
        {
            plat.enabled = true;
            physPlat.enabled = true;
            counter++;
        }
    }
}