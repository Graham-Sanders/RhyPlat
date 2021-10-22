using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(AudioSource))]
public class RhythmManager : MonoBehaviour
{
    public Rhythm beat;
    public int beathold;
    AudioSource source;
    public UnityEvent<int> onBeat = new UnityEvent<int>();

    public static RhythmManager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        source = GetComponent<AudioSource>();
        source.clip = beat.clip;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        int beatTime = (int) ((source.time - beat.firstBeat) % (beat.bpm / 60)) /
            ((beat.bpm / 60) - 1);
        //onBeat.Invoke((int)Time.time);
        if (beathold != beatTime)
        {
            onBeat.Invoke((int)beatTime);
            beathold = beatTime;
        }
    }
}
