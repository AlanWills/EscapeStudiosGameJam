using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAfterDelay : MonoBehaviour
{
    public float Delay = 1;
    public Behaviour Behaviour;

    private float currentTimer = 0;

	// Use this for initialization
	void Start ()
    {
        Behaviour.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentTimer += Time.deltaTime;
        if (currentTimer > Delay)
        {
            Behaviour.enabled = true;
            enabled = false;
        }
	}
}
