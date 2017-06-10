using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TimerLength = 10;

    private float currentTimer = 0;

    void Update()
    {
        currentTimer += Time.deltaTime;

        if (currentTimer > TimerLength)
        {
            // Do something
        }
    }
}