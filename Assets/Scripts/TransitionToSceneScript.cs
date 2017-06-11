using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    private static List<string> AvailableScenes = new List<string>()
    {
        "BlackAndWhiteWhiteCorrectLevel",
        "BlackAndWhiteBlackCorrectLevel",
        "HappyLevel",
        "HotAndColdLevel",
        "LeftBrainRightBrainLevel",
        "PlanesAndSubsOneColourLevel",
        "PressAllKeysLevel",
        "PressNoKeysLevel",
        "RunningManLevel",
        "SadLevel",
        "WhyDidTheChickenLevel",
        "WhyDidTheChickenSadLevel",
        "AdjustContrastLevel"
    };
    private static List<string> ScenesLeft = new List<string>(AvailableScenes);
    private static string currentLevelName;

    public Animator WipeAnimator;
    public float Countdown = 1;
    public float WipeCountdown = 1;

    private float countdownTimer = 0;
    private float wipeTimer = 0;
    private bool wiping = false;
    private bool transitioning = false;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!transitioning)
        {
            return;
        }

        countdownTimer += Time.deltaTime;

        if (countdownTimer < Countdown)
        {
            return;
        }

        wipeTimer += Time.deltaTime;

        if (!wiping && WipeAnimator != null)
        {
            WipeAnimator.SetTrigger("wipe");
            wiping = true;
        }

        if (wipeTimer < WipeCountdown)
        {
            return;
        }

        transitioning = false;

        if (ScenesLeft.Count == 0)
        {
            currentLevelName = "Complete";
        }
        else
        {
            currentLevelName = ScenesLeft[0];
            ScenesLeft.RemoveAt(0);
        }

        SceneManager.LoadScene(currentLevelName);
    }

    public void Transition()
    {
        transitioning = true;
    }

    public static void RandomizeScenes()
    {
        // Pushes the current scene to the buck of the ScenesLeft list.
        ScenesLeft.Add(currentLevelName);
    }
}
