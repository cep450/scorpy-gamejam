using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer myE;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

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

    void onTriggerStay() {
        if(Input.GetKey(KeyCode.E)) {
            //toggle being parented to player 

        }
    }

    void OnTriggerExit() {
        //if was player "raycast" 
        myE.enabled = false;
    }
}
