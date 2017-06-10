using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class ChickenController : MonoBehaviour
{
    public Vector2 Forward;
    public Vector2 Left;
    
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveBack();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveForward();
        }
    }

    private void MoveLeft()
    {
        transform.localPosition += new Vector3(Left.x, Left.y, 0) * Time.deltaTime;
    }

    private void MoveRight()
    {
        transform.localPosition += new Vector3(-Left.x, -Left.y, 0) * Time.deltaTime;
    }

    private void MoveForward()
    {
        transform.localPosition += new Vector3(Forward.x, Forward.y, 0) * Time.deltaTime;
    }

    private void MoveBack()
    {
        transform.localPosition += new Vector3(-Forward.x, -Forward.y, 0) * Time.deltaTime;
    }
}
