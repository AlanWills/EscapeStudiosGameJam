using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightController : MonoBehaviour
{
    public float Speed = 1;

	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            MoveRight();
        }
	}

    private void MoveLeft()
    {
        transform.localPosition += new Vector3(-Speed * Time.deltaTime, 0, 0);
    }

    private void MoveRight()
    {
        transform.localPosition += new Vector3(Speed * Time.deltaTime, 0, 0);
    }
}
