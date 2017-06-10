using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SetAnimatorTrigger : MonoBehaviour
{
    public string TriggerName;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Animator>().SetTrigger(TriggerName);
	}
}
