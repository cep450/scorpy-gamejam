using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpEr : MonoBehaviour
{

    float raycastDistance = 2.5f;

    public bool holdingSomething = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        
    }

    void FixedUpdate() {

        //raycast will come from camera 
        //sends out a raycast that will trigger any triggers
        //pickups will have code for this 
        Physics.Raycast(transform.position, Vector3.forward, raycastDistance, 0, QueryTriggerInteraction.Collide);

        //TODO layer mask number. make one for pickups? 

    }
}
