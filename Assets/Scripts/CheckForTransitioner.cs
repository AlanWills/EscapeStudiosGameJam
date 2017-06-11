using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForTransitioner : MonoBehaviour
{
    public GameObject TransitionerPrefab;

    private static GameObject transitioner;

    private void Awake()
    {
        if (transitioner == null)
        {
            transitioner = Instantiate(TransitionerPrefab);
            transitioner.GetComponent<RandomizeScenes>().DoStep();
        }
    }

    public static void Transition()
    {
        transitioner.GetComponent<TransitionToSceneScript>().Transition();
    }
}
