using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KeepScore : MonoBehaviour
{

    public int Score;
    public Text ScoreText;
    public Text StateText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Score >= 5)
            YouWin();
    }

    void YouWin()
    {
        StateText.text = "You Succeed to Collect Plants!\n\nPress Space to back to Main Menu";
        Time.timeScale = 0f;
        if (Input.GetKey(KeyCode.Space))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Scenes/MainMenu");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision Detected " + col.gameObject.name);
        if (col.gameObject.name == "plant")
        {
            Score++;
            ScoreText.text = string.Format("Collected {0}", Score);
        }
    }
}
