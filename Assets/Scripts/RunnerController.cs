using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Animator))]
public class RunnerController : MonoBehaviour
{
    public GameObject step1;
    public GameObject step2; 
    public GameObject flip;
    public GameObject hurt;
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
            GameObject audioInstance;
            audioInstance = Instantiate(hurt, transform) as GameObject;
            SceneManager.LoadScene("RunningManLevel");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Success")
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

            GameObject audioInstance;
            audioInstance = Instantiate(flip, transform) as GameObject;

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

            GameObject audioInstance;
            audioInstance = Instantiate(flip, transform) as GameObject;

        }

    }

    private void Step1(){
        GameObject audioInstance;
        audioInstance = Instantiate(step1, transform) as GameObject;
    }
    private void Step2()
    {
        GameObject audioInstance;
        audioInstance = Instantiate(step2, transform) as GameObject;
    }
}
