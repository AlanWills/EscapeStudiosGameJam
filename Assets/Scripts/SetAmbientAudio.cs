using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAmbientAudio : MonoBehaviour
{
    public bool AmbientAudio = true;

    public GameObject AmbientMusicLoader;

    private void Awake()
    {
        if (CheckForAmbientMusic.AmbientMusicLoader == null)
        {
            CheckForAmbientMusic.AmbientMusicLoader = Instantiate(AmbientMusicLoader);
        }
    }

    // Use this for initialization
    void Start()
    {
        CheckForAmbientMusic.ShouldAmbientMusicPlay = AmbientAudio;
    }
}
