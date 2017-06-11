using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomStepPlayerOnKeyPress : CustomStepPlayer
{
    public List<KeyCode> Keys = new List<KeyCode>();

	// Update is called once per frame
	void Update ()
    {
		if (Keys.Count == 0 && Input.anyKeyDown)
        {
            PlaySteps();
        }
        else if (Keys.Exists(x => Input.GetKeyDown(x)))
        {
            PlaySteps();
        }
	}
}
