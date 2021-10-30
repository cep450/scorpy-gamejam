using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer myE;

    bool parentedToPlayer = false;

    Rigidbody myrb;

    Vector3 pickedUpPos;
    float rubberBandRate = 10f;

    void Start()
    {
        myrb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    void FixedUpdate() {

        //when held, velocity should always be 0 
        if(parentedToPlayer) {

            myrb.velocity = Vector3.zero;

            //try to stay where it was picked up from 
            //public static Vector3 MoveTowards(Vector3 current, Vector3 target, float maxDistanceDelta);
            //transform.Translate(Vector3.MoveTowards(transform.position, Vector3.zero, rubberBandRate * Time.deltaTime));

            if(Input.GetKeyDown(KeyCode.E)) {
                transform.SetParent(null);
                parentedToPlayer = false;
                myrb.useGravity = true;
            }

        }
        

    }


    //raycast hit me! 
        //at least, check it was the PickUpEr who hit me 
        //show my "E" 
        //if the player presses E when i'm showing my E 
        //set the camera as my parent 
        //if the player presses E again when i'm parented, unparent myself 

    void OnTriggerEnter() {
        //if was player "raycast"
        myE.enabled = true;
    }

    void OnTriggerStay() {
        if(Input.GetKeyDown(KeyCode.E)) {
            //toggle being parented to player 
            //public void SetParent(Transform p);
            if(!parentedToPlayer) {
                transform.SetParent(Camera.main.transform);
                parentedToPlayer = true;
                myE.enabled = false;
                myrb.useGravity = false;
                //pickedUpPos = transform.position;
                
            }

        }


    }

    void OnTriggerExit() {
        //if was player "raycast" 
        myE.enabled = false;
    }
}
