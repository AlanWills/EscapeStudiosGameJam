using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class SidewaysScroller : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D objectRigidBody;

	// Use this for initialization
	void Start ()
    {
        objectRigidBody = GetComponent<Rigidbody2D>();
        objectRigidBody.velocity = new Vector2(Speed, 0);
	}
	
	// Update is called once per frame
	void Update ()
    {
	}
}
