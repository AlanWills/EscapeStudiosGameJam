using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForKeyboardInput : ConditionScript
{
    
    // Update is called once per frame
    void Update ()
    {
        if (!Input.GetKeyUp(KeyCode.RightArrow))
        {
            return;
        }

        Correct();
        enabled = false;
    }
    
}
