using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{

    public float TimeValue = 100;
    public Text TimerText;
    public Text StateText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeValue > 0)
            TimeValue -= Time.deltaTime;
        
        else
        {
            TimeValue = 0;
        }

        DisplayTime(TimeValue);        
    }

    void DisplayTime(float TimeToDisplay)
    {
        if (TimeToDisplay < 0)
        {
            TimeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(TimeToDisplay / 60);
        float seconds = Mathf.FloorToInt(TimeToDisplay % 60);

        TimerText.text = string.Format("Time Remaining {0:00}:{1:00}", minutes, seconds);

        if (TimeToDisplay <= 0)
        {
            StateText.text = "You Failed to Collect Plants!\n\nPress Space to Back to Main Menu";
            Time.timeScale = 0f;
            if (Input.GetKey(KeyCode.Space))
            {
                Time.timeScale = 1f;
                SceneManager.LoadScene("Scenes/MainMenu");
            }
        }

    }
}
