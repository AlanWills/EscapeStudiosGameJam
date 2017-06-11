using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddHardLevel : CustomStep
{
    public string LevelName;

    public override void DoStep()
    {
        TransitionToSceneScript.ScenesLeft.Add(LevelName);
    }
}
