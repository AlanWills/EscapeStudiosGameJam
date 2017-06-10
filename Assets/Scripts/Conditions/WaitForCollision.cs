using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class WaitForCollision : ConditionScript
{
    private bool collided = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collided = true;
    }

    protected override bool Condition() { return collided; }
}