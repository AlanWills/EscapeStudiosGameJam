using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class RunnerController : MonoBehaviour
{
    private enum Orientation
    {
        kUp,
        kDown
    }

    private Animator runnerAnimator;
    private Orientation orientation = Orientation.kUp;

	// Use this for initialization
	void Start ()
    {
        runnerAnimator = GetComponent<Animator>();
        runnerAnimator.SetTrigger("running");

        SetUp();
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            SetUp();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            SetDown();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Collidable")
        {
            SceneManager.LoadScene("RunningManLevel");
        }
    }

    private void SetUp()
    {
        if (orientation != Orientation.kUp)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.y *= -1;
            transform.localPosition = localPosition;
            GetComponentInChildren<SpriteRenderer>().flipY = false;
            orientation = Orientation.kUp;
        }
    }

    private void SetDown()
    {
        if (orientation != Orientation.kDown)
        {
            Vector3 localPosition = transform.localPosition;
            localPosition.y *= -1;
            transform.localPosition = localPosition;
            GetComponentInChildren<SpriteRenderer>().flipY = true;
            orientation = Orientation.kDown;
        }
    }
}
