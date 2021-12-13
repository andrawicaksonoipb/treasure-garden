using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraController : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private float mouseSensitivity;
    public Text StateText;
    public Text PauseText;

    //REFERENCES
    private Transform parent;

    private void Start()
    {
        parent = transform.parent;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        RotateX();
        RotateY();
        Pause();
    }

    private void RotateX()
    {
        float mouseX = Input.GetAxis("Horizontal") * mouseSensitivity * Time.deltaTime;

        parent.Rotate(Vector3.up, mouseX);
    }

    private void RotateY()
    {
        float mouseY = Input.GetAxis("Mouse Y") * 1 * Time.deltaTime;

        transform.Rotate(Vector3.right, mouseY);
    }

    private void Pause()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Time.timeScale = 0f;
            StateText.text = "Paused\n\n";
            PauseText.text = "Press Enter to Continue\nPress Backspace to Back to Main Menu";
        }
    }
}
