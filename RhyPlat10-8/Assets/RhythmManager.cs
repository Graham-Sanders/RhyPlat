using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(AudioSource))]
public class RhythmManager : MonoBehaviour
{
    public Rythm beat;
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
        int beatTime = (int) ((source.time - beat.firstBeat) % (beat.bpn / 60)) /
            ((beat.bpn / 60) - 1);
        //onBeat.Invoke((int)Time.time);
        onBeat.Invoke((int)beatTime);

    }
}
