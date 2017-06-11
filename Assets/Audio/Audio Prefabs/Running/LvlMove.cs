using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvlMove : MonoBehaviour {
    public GameObject lvlMove1;
    public GameObject lvlMove2;
    public GameObject flip;
    GameObject currentSound;

    public float interval;
    int soundId = 1;

    float lasttimeCheck;
    // Use this for initialization
    void Start () {
        lasttimeCheck = Time.time;
        currentSound = lvlMove1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - lasttimeCheck > interval)
        {
            GameObject audioInstance;
            audioInstance = Instantiate(currentSound, transform) as GameObject;
            lasttimeCheck = Time.time;
            if (soundId == 1)
            {
                soundId = 2;
                currentSound = lvlMove2;
            } else
            {
                soundId = 1;
                currentSound = lvlMove1;
            }
        }
	}
}
