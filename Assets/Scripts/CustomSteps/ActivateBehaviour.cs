using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateBehaviour : CustomStep
{
    public Behaviour Component;

    public override void OnFailure()
    {
    }

    public override void OnSuccess()
    {
        Component.enabled = true;
    }
}
