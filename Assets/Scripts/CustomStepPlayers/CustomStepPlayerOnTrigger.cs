using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class CustomStepPlayerOnTrigger : CustomStepPlayer
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlaySteps();
    }
}
