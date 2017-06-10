using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionToSceneScript : MonoBehaviour
{
    public Animator WipeAnimator;
    public string SceneName;
    public float Countdown = 1.5f;
    public float WipeCountdown = 1;
    public string AxisToTrigger;

    private float currentTime = 0;
    private bool wiping = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Countdown > 0)
        {
            currentTime += Time.deltaTime;

            if (currentTime > Countdown)
            {
                ForceTransition();
            }
        }
        else if (!string.IsNullOrEmpty(AxisToTrigger) && Input.GetAxis(AxisToTrigger) > 0)
        {
            ForceTransition();
        }
	}

    public void ForceTransition()
    {
        if (!wiping && WipeAnimator != null)
        {
            currentTime = 0;
            WipeAnimator.SetTrigger("wipe");
            wiping = true;
        }

        if (currentTime < WipeCountdown)
        {
            return;
        }

        SceneManager.LoadScene(SceneName);
    }
}
