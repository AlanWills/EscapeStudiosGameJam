using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetVolume : CustomStep
{
    public float Volume;
    public AudioSource AudioSource;

    public override void DoStep()
    {
        AudioSource.volume = Volume;
    }
}
