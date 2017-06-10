using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class RunnerController : MonoBehaviour
{
    private Animator runnerAnimator;

	// Use this for initialization
	void Start ()
    {
        runnerAnimator = GetComponent<Animator>();
        runnerAnimator.SetTrigger("running");
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
