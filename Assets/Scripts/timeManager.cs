using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeManager : MonoBehaviour
{
    public Text timeLimitText;
    public Text remainingTimeText;
    public float timeLimit = 10.0f; // for faster testing
    public float timeRemaining;

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeLimit;
        timeLimitText.text = "time limit: " + timeLimit.ToString("F2");
        remainingTimeText.text = "time remainng: " + timeRemaining.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        timeRemaining -= Time.deltaTime;
        if (timeRemaining > 0)  // NOT equal!
        {
            remainingTimeText.text = "time remainng: " + timeRemaining.ToString("F2");
        }
        else
        {
            //remainingTimeText.text = "GAME OVER";
            SceneManager.LoadScene("Exit");
        }
    }
}
