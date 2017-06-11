using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetGameObjectActive : MonoBehaviour
{
    public GameObject GameObject;

    private void Start()
    {
        GameObject.SetActive(false);
    }
    
    public void Show()
    {
        GameObject.SetActive(true);
    }
}
