using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class WaitForTrigger : ConditionScript
{
    public string TagToCheckFor;

    private bool collided = false;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == TagToCheckFor)
        {
            collided = true;
        }
    }

    protected override bool Condition() { return collided; }
}