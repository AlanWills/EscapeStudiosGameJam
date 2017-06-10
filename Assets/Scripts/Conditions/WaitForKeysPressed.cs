using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForKeysPressed : ConditionScript
{
    public List<KeyCode> Keys = new List<KeyCode>();

    private Dictionary<KeyCode, bool> keysPressed = new Dictionary<KeyCode, bool>();

    public override void Start()
    {
        base.Start();

        foreach (KeyCode key in Keys)
        {
            keysPressed.Add(key, false);
        }
    }

    // Update is called once per frame
    public override void Update ()
    {
        base.Update();

        foreach (KeyCode key in Keys)
        {
            bool keyAlreadyPressed = keysPressed[key];
            keysPressed[key] = keyAlreadyPressed || Input.GetKeyDown(key);
        }
    }
    
    protected override bool Condition()
    {
        foreach (KeyCode key in Keys)
        {
            if (!keysPressed[key])
            {
                return false;
            }
        }

        return true;
    }
}
