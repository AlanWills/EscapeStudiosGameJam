using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetTriggerCustomStep : CustomStep
{
    public string TriggerOnSuccess;
    public Animator Animator;
    
    public override void OnSuccess()
    {
        Animator.SetTrigger(TriggerOnSuccess);
    }

    public override void OnFailure()
    {
    }
}
