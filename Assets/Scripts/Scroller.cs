using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Scroller : MonoBehaviour
{
    public Vector2 Speed;
    private Rigidbody2D objectRigidBody;

	// Use this for initialization
	void Start ()
    {
        objectRigidBody = GetComponent<Rigidbody2D>();
        objectRigidBody.velocity = Speed;
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
}
