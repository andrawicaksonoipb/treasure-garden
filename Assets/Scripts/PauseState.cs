using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseState : MonoBehaviour
{
    public Text StateText;
    public Text Pause;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            StateText.text = "";
            Pause.text = "";
            Time.timeScale = 1f;
        }
        else if (Input.GetKey(KeyCode.Backspace))
            SceneManager.LoadScene("Scenes/MainMenu");
    }
}
