using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMouseMove : MonoBehaviour
{

    /*
        rotate the whole player left and right 
        just rotate the camera up and down 
    */

    float sensitivity = 10f;

    float degreescap = 85f;

    public Transform cameraTransform;
    public Transform playerTransform;

    float xrotation = 0f;
    float yrotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //rotate whole player left and right

        //this also works, but might as well do everyting at once with the below 
        //playerTransform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);

        xrotation += Input.GetAxis("Mouse X") * sensitivity;
        xrotation = Mathf.Repeat(xrotation, 360);

        //never let the player rotate on any other axis 
        playerTransform.rotation = Quaternion.Euler(0, xrotation, 0);
        
        
        //only rotate the camera up and down 
        //but, cap it up and down 
        //https://answers.unity.com/questions/1344322/free-mouse-rotating-camera.html
        yrotation -= Input.GetAxis("Mouse Y") * sensitivity;
        yrotation = Mathf.Clamp(yrotation, -degreescap, degreescap);
        cameraTransform.rotation = Quaternion.Euler(yrotation, cameraTransform.eulerAngles.y, cameraTransform.eulerAngles.z);
        
    }
}
