using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleObjectChooser : MonoBehaviour
{
    public List<GameObject> ObjectsToChooseFrom = new List<GameObject>();

    // Use this for initialization
    void Awake()
    {
        int index = Random.Range(0, ObjectsToChooseFrom.Count);

        for (int i = 0; i < ObjectsToChooseFrom.Count; ++i)
        {
            ObjectsToChooseFrom[i].SetActive(i == index);
        }
	}
}
