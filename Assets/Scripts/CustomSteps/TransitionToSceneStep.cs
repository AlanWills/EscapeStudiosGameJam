using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToSceneStep : CustomStep
{
    public TransitionToSceneScript TransitionScript;

    public override void DoStep()
    {
        TransitionScript.ForceTransition();
    }
}
