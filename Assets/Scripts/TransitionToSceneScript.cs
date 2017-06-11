using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    private static List<string> AvailableScenes = new List<string>()
    {
        "BlackAndWhiteLevel",
        //"HappyLevel",
        //"HotAndColdLevel",
        //"LeftBrainRightBrainLevel",
        "PlanesAndSubsOneColourLevel",
        //"PressAllKeysLevel",
        //"PressNoKeysLevel",
        //"RunningManLevel",
        //"SadLevel",
        //"WhyDidTheChickenLevel",
        //"WhyDidTheChickenSadLevel"
    };
    private static List<string> ScenesLeft = new List<string>()
    {
        "BlackAndWhiteLevel",
        //"HappyLevel",
        //"HotAndColdLevel",
        //"LeftBrainRightBrainLevel",
        "PlanesAndSubsOneColourLevel",
        //"PressAllKeysLevel",
        //"PressNoKeysLevel",
        //"RunningManLevel",
        //"SadLevel",
        //"WhyDidTheChickenLevel",
        //"WhyDidTheChickenSadLevel"
    };

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
        string scene = ScenesLeft[0];
        ScenesLeft.RemoveAt(0);
        SceneManager.LoadScene(scene);
    }

    public void Transition()
    {
        transitioning = true;
    }

    public static void RandomizeScenes()
    {
        int n = AvailableScenes.Count;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            string value = AvailableScenes[k];
            AvailableScenes[k] = AvailableScenes[n];
            AvailableScenes[n] = value;
        }

        ScenesLeft.Clear();
        ScenesLeft.AddRange(AvailableScenes);
    }
}
