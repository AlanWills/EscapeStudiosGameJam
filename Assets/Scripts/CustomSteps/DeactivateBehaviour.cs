using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateBehaviour : CustomStep
{
    public Behaviour Component;

    public override void DoStep()
    {
        Component.enabled = false;
    }
}
