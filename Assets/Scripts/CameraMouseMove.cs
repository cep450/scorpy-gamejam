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

    public Transform cameraTransform;
    public Transform playerTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("leftright: " + Input.GetAxis("Horizontal"));

        //rotate whole player left and right 
        playerTransform.Rotate(-Input.GetAxis("Horizontal") * sensitivity, 0, 0); 
        //only rotate the camera up and down 
        cameraTransform.Rotate(0, Input.GetAxis("Vertical") * sensitivity, 0);
        
    }
}
