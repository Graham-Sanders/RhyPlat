using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Rhythm : ScriptableObject
{
    public AudioClip clip;
    public int firstBeat;
    public int bpm;
}
