using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : CustomStep
{
    public AudioSource AudioSource;
    
    public override void OnSuccess()
    {
        AudioSource.Play();
    }

    public override void OnFailure()
    {
    }
}
