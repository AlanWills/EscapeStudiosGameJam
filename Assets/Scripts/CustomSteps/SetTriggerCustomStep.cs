using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class SetTriggerCustomStep : CustomStep
{
    public string TriggerOnSuccess;
    
    public override void OnSuccess()
    { 
        gameObject.GetComponent<Animator>().SetTrigger(TriggerOnSuccess);
    }

    public override void OnFailure()
    {
    }
}
