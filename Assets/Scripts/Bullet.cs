using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class Bullet : MonoBehaviour
{
    public GameObject Target;
    public float Speed;

    private Rigidbody2D objectRigidBody2D;

    private void Start()
    {
        objectRigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update ()
    {
        Vector3 diff = (Target.transform.position - transform.position);
        diff.z = 0;
        diff.Normalize();
        transform.position += new Vector3(diff.x, diff.y, 0) * Speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
