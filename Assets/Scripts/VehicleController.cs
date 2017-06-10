using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Scroller))]
public class VehicleController : MonoBehaviour
{
    public Transform SpawnPoint;

	// Use this for initialization
	void Start ()
    {
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Level")
        {
            transform.position = SpawnPoint.position;
        }
    }
}
