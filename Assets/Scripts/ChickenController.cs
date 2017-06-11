using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(ParticleSystem))]
[RequireComponent(typeof(AudioSource))]
public class ChickenController : MonoBehaviour
{
    public Vector2 Forward;
    public Vector2 Left;
    public ParticleSystem DeathParticleSystem;
    public AudioClip ChickenDeathSound;
    public WaitUntilTrue OptionalWait;

    private Animator chickenAnimator;
    private AudioSource chickenAudio;
    private bool moving = false;
    
    // Use this for initialization
    void Start ()
    {
        chickenAnimator = GetComponent<Animator>();
        chickenAnimator.SetTrigger("idle");

        chickenAudio = GetComponent<AudioSource>();

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
            // Turn off visuals and collisions
            GetComponentInChildren<SpriteRenderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
            DeathParticleSystem.Emit(31);

            chickenAudio.loop = false;
            chickenAudio.clip = ChickenDeathSound;
            chickenAudio.Play();

            if (OptionalWait != null)
            {
                OptionalWait.IsTrue = true;
            }
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
            chickenAudio.Play();
        }
    }

    private void TryStop()
    {
        if (moving)
        {
            moving = false;
            chickenAnimator.SetTrigger("running");
            chickenAudio.Stop();
        }
    }
}
