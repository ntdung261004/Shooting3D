using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera cam;
    private float xRotation = 0f;    

    public float xSensitivy = 30f;
    public float ySensitivy = 30f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        //Calculate camera roration for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivy;
        xRotation = Mathf.Clamp(xRotation, -80f, 80);

        //Aplly this to our Camera transform 
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //Rotate player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivy);
    }    
}
