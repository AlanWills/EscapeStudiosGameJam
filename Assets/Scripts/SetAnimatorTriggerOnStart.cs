using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class SetAnimatorTriggerOnStart : MonoBehaviour
{
    public string TriggerName;

	// Use this for initialization
	void Start ()
    {
        GetComponent<Animator>().SetTrigger(TriggerName);
	}
}
