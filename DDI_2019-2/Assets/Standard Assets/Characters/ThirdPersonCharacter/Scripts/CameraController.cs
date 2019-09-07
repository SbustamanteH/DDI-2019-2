using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraTarget;
    public float rotationSpeed = 10f;

    public Vector2 limitY = new Vector2(-30,60);
    private float mouseX, mouseY;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        mouseX += Input.GetAxis("Mouse X") * rotationSpeed;
        mouseY += Input.GetAxis("Mouse Y") * rotationSpeed * -1;
        mouseY = Mathf.Clamp(mouseY,limitY.x,limitY.y);
        cameraTarget.rotation = Quaternion.Euler(mouseY,mouseX,0);
        transform.LookAt(cameraTarget);
       
    }
}
