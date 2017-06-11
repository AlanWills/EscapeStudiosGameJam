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

    public GameObject Background;

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
        else
        {
            runnerAnimator.SetTrigger("idle");
        }
    }

    private void SetUp()
    {
        if (orientation != Orientation.kUp)
        {
            // Scope to avoid setting variables incorrectly
            {
                Vector3 localPosition = transform.localPosition;
                localPosition.y *= -1;
                transform.localPosition = localPosition;
            }

            {
                Vector3 backgroundPosition = Background.transform.localPosition;
                backgroundPosition.y *= -1;
                Background.transform.localPosition = backgroundPosition;
            }

            GetComponentInChildren<SpriteRenderer>().flipY = false;
            orientation = Orientation.kUp;
        }
    }

    private void SetDown()
    {
        if (orientation != Orientation.kDown)
        {
            // Scope to avoid setting variables incorrectly
            {
                Vector3 localPosition = transform.localPosition;
                localPosition.y *= -1;
                transform.localPosition = localPosition;
            }

            {
                Vector3 backgroundPosition = Background.transform.localPosition;
                backgroundPosition.y *= -1;
                Background.transform.localPosition = backgroundPosition;
            }

            GetComponentInChildren<SpriteRenderer>().flipY = true;
            orientation = Orientation.kDown;
        }
    }
}
