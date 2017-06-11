using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class CustomStepPlayerOnCollision : CustomStepPlayer
{
    public string TagToCheckFor;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (string.IsNullOrEmpty(TagToCheckFor) || collision.gameObject.tag == TagToCheckFor)
        {
            PlaySteps();
        }
    }
}