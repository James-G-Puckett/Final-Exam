using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text remainingTime;

    public float timeLimit = 50f;
    public float timeRemaining;
    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeLimit;
        timeLimit = KeepData.time;

        remainingTime.text = timeRemaining.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining >= 0)
        {
            remainingTime.text = timeRemaining.ToString("F2");
        }
        else
        {
            remainingTime.text = "Out of time";
        }
    }
}
