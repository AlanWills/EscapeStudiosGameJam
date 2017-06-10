using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CorrectBrainSequencePressed : ConditionScript
{
    public Animator PlayerAnimator;

    private Animator brainAnimator;
    bool upPressed = false;
    bool leftPressed = false;
    bool downPressed = false;

    void Start()
    {
        brainAnimator = GetComponent<Animator>();
    }

    public override void Update()
    {
        base.Update();

        if (Condition())
        {
            // Don't allow input changes when complete
            return;
        }

        if (!upPressed)
        {
            // Nothing in the sequence is pressed

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                upPressed = true;
                brainAnimator.SetTrigger("next");
            }
        }
        else if (!leftPressed)
        {
            // Up pressed, but nothing else

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                leftPressed = true;
                brainAnimator.SetTrigger("next");
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                upPressed = false;
                brainAnimator.SetTrigger("previous");
            }
        }
        else if (!downPressed)
        {
            // Up and left pressed, but not down

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                downPressed = true;
                brainAnimator.SetTrigger("next");
                PlayerAnimator.SetTrigger("clever");
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                leftPressed = false;
                brainAnimator.SetTrigger("previous");
            }
        }
    }

    protected override bool Condition()
    {
        return upPressed && leftPressed && downPressed;
    }
}
