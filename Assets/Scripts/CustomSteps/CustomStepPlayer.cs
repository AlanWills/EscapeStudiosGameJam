using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomStepPlayer : MonoBehaviour
{
    public List<CustomStep> OptionalCustomSteps = new List<CustomStep>();

    public void PlaySteps()
    {
        foreach (CustomStep customStep in OptionalCustomSteps)
        {
            customStep.DoStep();
        }
    }
}
