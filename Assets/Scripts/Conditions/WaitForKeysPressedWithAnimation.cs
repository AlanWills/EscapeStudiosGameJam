using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Animator))]
public class WaitForKeysPressedWithAnimation : WaitForKeysPressed
{
    public string TriggerOnSuccess;
    
    protected override void OnCorrect()
    {
        base.OnCorrect();

        gameObject.GetComponent<Animator>().SetTrigger(TriggerOnSuccess);
    }
}
