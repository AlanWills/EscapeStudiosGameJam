using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(ParticleSystem))]
public class ChickenController : MonoBehaviour
{
    public Vector2 Forward;
    public Vector2 Left;
    public GameObject chickenThoughts;
    public ParticleSystem DeathParticleSystem;

    private Animator chickenAnimator;
    private bool moving = false;
    
    // Use this for initialization
    void Start ()
    {
        chickenAnimator = GetComponent<Animator>();
        chickenAnimator.SetTrigger("idle");

        DeathParticleSystem.Stop();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKey(KeyCode.LeftArrow))
        {
            MoveLeft();
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            MoveRight();
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            MoveForward();
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            MoveBack();
        }
        else
        {
            TryStop();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collidable")
        {
            gameObject.GetComponentInChildren<SpriteRenderer>().enabled = false;
            DeathParticleSystem.Emit(31);
        }
    }
    
    private void MoveLeft()
    {
        transform.localPosition += new Vector3(Left.x, Left.y, 0) * Time.deltaTime;

        TryRun();
    }

    private void MoveRight()
    {
        transform.localPosition += new Vector3(-Left.x, -Left.y, 0) * Time.deltaTime;

        TryRun();
    }

    private void MoveForward()
    {
        transform.localPosition += new Vector3(Forward.x, Forward.y, 0) * Time.deltaTime;

        TryRun();
    }

    private void MoveBack()
    {
        transform.localPosition += new Vector3(-Forward.x, -Forward.y, 0) * Time.deltaTime;

        TryRun();
    }

    private void TryRun()
    {
        if (!moving)
        {
            moving = true;
            chickenAnimator.SetTrigger("running");
            chickenThoughts.SetActive(false);
        }
    }

    private void TryStop()
    {
        if (moving)
        {
            moving = false;
            chickenAnimator.SetTrigger("running");
        }
    }
}
