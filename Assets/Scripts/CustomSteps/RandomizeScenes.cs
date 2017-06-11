using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeScenes : CustomStep
{
    public override void DoStep()
    {
        TransitionToSceneScript.RandomizeScenes();
    }
}