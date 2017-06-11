using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TransitionToSceneScript))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class FireAtObject : MonoBehaviour
{
    public List<CustomStep> CustomSteps = new List<CustomStep>();
    public List<BulletFirer> Firers = new List<BulletFirer>();
    public KeyCode KeyToTrigger;
    public Animator Animator;
    public Rigidbody2D RigidBody;

    private bool alive = true;
    
	// Update is called once per frame
	void Update ()
    {
	    if (Input.GetKeyDown(KeyToTrigger))
        {
            DoFiring();
        }
	}

    private void DoFiring()
    {
        foreach (CustomStep step in CustomSteps)
        {
            step.DoStep();
        }

        foreach (BulletFirer firer in Firers)
        {
            firer.Fire(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (alive)
        {
            alive = false;
            RigidBody.velocity = Vector3.zero;
            Animator.SetTrigger("die");
        }
    }
}