using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    public static List<string> AvailableScenes = new List<string>();

    private static Queue<string> currentSceneQueue = new Queue<string>();

    public Animator WipeAnimator;
    public float Countdown = 1;
    public float WipeCountdown = 1;

    private float countdownTimer = 0;
    private float wipeTimer = 0;
    private bool wiping = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    public void ForceTransition()
    {
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

        SceneManager.LoadScene(currentSceneQueue.Dequeue());
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

        foreach (string scene in AvailableScenes)
        {
            currentSceneQueue.Enqueue(scene);
        }
    }
}
