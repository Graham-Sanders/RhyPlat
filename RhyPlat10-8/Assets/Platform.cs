using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        RhythmManager.instance.onBeat.AddListener(OnBeat);
    }

    public void OnBeat(int beat)
    {
        if(beat != )
    }
    
}
