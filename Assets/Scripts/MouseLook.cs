using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public void AdjustSens(float newSens) {
            mouseSensitivity = newSens;
    }

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        if (Input.GetButtonDown("Cancel"))
         {
             //Actives Menu Canvas
             Cursor.lockState = CursorLockMode.None;
             Cursor.visible = true;
        }

        if(Input.GetMouseButtonDown(0))
         {
             //Actives Menu Canvas
             Cursor.lockState = CursorLockMode.Locked;
             Cursor.visible = false;
        }
    }
}
