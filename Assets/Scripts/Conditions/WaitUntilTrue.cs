using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitUntilTrue : ConditionScript
{
    public bool IsTrue;

    protected override bool Condition()
    {
        return IsTrue;
    }
}
