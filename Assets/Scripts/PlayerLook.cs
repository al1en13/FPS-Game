using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{

    public Camera cam;

    private float xRotation = 0f;

    public float sensitivity = 30f;

    public void Look(Vector2 input)
    {
        float mouseX = input.x * Time.deltaTime * sensitivity;
        float mouseY = input.y * Time.deltaTime * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        transform.Rotate(Vector3.up * mouseX);

    }
}
