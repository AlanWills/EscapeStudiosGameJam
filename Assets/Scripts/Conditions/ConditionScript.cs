using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TransitionToSceneScript))]
public abstract class ConditionScript : CustomStepPlayer
{
    public bool Reversed = false;
    private GameObject correctSymbol;
    private GameObject incorrectSymbol;
    private TransitionToSceneScript transitionScript;

	// Use this for initialization
	public virtual void Awake()
    {
        correctSymbol = GameObject.Find("CorrectSymbol");
        Debug.Assert(correctSymbol != null, "Correct symbol null");
        correctSymbol.SetActive(false);

        incorrectSymbol = GameObject.Find("IncorrectSymbol");
        Debug.Assert(incorrectSymbol != null, "Incorrect symbol null");
        incorrectSymbol.SetActive(false);

        transitionScript = GetComponent<TransitionToSceneScript>();
        Debug.Assert(transitionScript != null, "Transition script null");
        transitionScript.enabled = false;
    }

    public virtual void Update()
    {
        bool isConditionSatisfied = Condition();
        if (isConditionSatisfied != Reversed)
        {
            // This means that if we're not reversed the condition is satisfied
            // If we are reversed the condition is not satisfied, so actually IS satisfied!
            Correct();
        }
    }

    protected abstract bool Condition();
	
    private void Correct()
    {
        correctSymbol.SetActive(true);
        transitionScript.enabled = true;
        enabled = false;

        foreach (CustomStep customStep in OptionalCustomSteps)
        {
            customStep.DoStep();
        }
    }
}
