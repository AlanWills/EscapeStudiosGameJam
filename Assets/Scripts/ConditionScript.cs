using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TransitionToSceneScript))]
public abstract class ConditionScript : MonoBehaviour
{
    private GameObject correctSymbol;
    private TransitionToSceneScript transitionScript;

	// Use this for initialization
	void Start()
    {
        correctSymbol = GameObject.Find("CorrectSymbol");
        Debug.Assert(correctSymbol != null, "Correct symbol null");
        correctSymbol.SetActive(false);

        transitionScript = GetComponent<TransitionToSceneScript>();
        Debug.Assert(transitionScript != null, "Transition script null");
        transitionScript.enabled = false;
    }
	
    protected void Correct()
    {
        correctSymbol.SetActive(true);
        transitionScript.enabled = true;
    }
}
