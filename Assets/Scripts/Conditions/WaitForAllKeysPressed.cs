using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForAllKeysPressed : ConditionScript
{
    public float KeyPressBuffer = 2f;
    private float currentTimer = 0;

    private bool leftDown = false;
    private bool upDown = false;
    private bool rightDown = false;
    private bool downDown = false;

    // Update is called once per frame
    public override void Update ()
    {
        base.Update();

        //currentTimer += Time.deltaTime;
        //if (currentTimer < KeyPressBuffer)
        {
            leftDown = leftDown || Input.GetKeyDown(KeyCode.LeftArrow) || (Input.GetAxis("Left") > 0);
            upDown = upDown || Input.GetKeyDown(KeyCode.UpArrow) || (Input.GetAxis("Up") > 0);
            rightDown = rightDown || Input.GetKeyDown(KeyCode.RightArrow) || (Input.GetAxis("Right") > 0);
            downDown = downDown || Input.GetKeyDown(KeyCode.DownArrow) || (Input.GetAxis("Down") > 0);

            //DebugPrint();
        }

        //Flush();
    }

    private void DebugPrint()
    {
        if (leftDown) { print("Left down"); }
        if (upDown) { print("Up down"); }
        if (rightDown) { print("Right down"); }
        if (downDown) { print("Down down"); }
    }

    protected override bool Condition()
    {
        return leftDown && upDown && rightDown && downDown;
    }

    private void Flush()
    {
        leftDown = false;
        upDown = false;
        rightDown = false;
        downDown = false;
        currentTimer = 0;
    }
}
