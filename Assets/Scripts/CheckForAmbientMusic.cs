using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForAmbientMusic : MonoBehaviour
{
    public static bool ShouldAmbientMusicPlay
    {
        set
        {
            AmbientMusicLoader.GetComponent<AudioSource>().volume = value ? 0.3f : 0;
        }
    }

    public static GameObject AmbientMusicLoader;
}
