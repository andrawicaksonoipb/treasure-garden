using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private float mouseSensitivity;

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

}
