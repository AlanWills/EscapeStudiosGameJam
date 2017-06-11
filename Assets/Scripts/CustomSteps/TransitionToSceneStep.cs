using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToSceneStep : CustomStep
{
    public TransitionToSceneScript Transitioner;

    public override void DoStep()
    {
        Transitioner.Transition();
    }
}
