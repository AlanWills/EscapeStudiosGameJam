using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyObjectOnLoad : MonoBehaviour
{
    public GameObject GameObjectToPreserve;
    
    void Awake()
    {
        DontDestroyOnLoad(GameObjectToPreserve);
    }
}
