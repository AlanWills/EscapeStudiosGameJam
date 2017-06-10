using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForRightArrowPressed : ConditionScript
{
    protected override bool Condition()
    {
        return Input.GetKeyDown(KeyCode.RightArrow);
    }
}