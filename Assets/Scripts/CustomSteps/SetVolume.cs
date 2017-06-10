using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolume : CustomStep
{
    public float Volume;
    public AudioSource AudioSource;

    public override void OnSuccess()
    {
        AudioSource.volume = Volume;
    }

    public override void OnFailure()
    {
    }
}
