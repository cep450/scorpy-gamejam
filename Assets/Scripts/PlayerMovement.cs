using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float speed = 9f;
    float speedDiag;
    //float acceleration;
    //float velocityCap;

    float initialy;

    // Start is called before the first frame update
    void Start()
    {
        speedDiag = speed * Mathf.Sin(Mathf.PI / 4);
        initialy = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
         

    }

    void FixedUpdate() {

        //controls 
        bool up = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool down = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);
        bool left = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool right = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);

        float effectivespeed;

        if((up || down ) && (left || right)) {
            effectivespeed = speedDiag;
        } else {
            effectivespeed = speed;
        }

        //move, relative to what way we're facing (since, camera is turning us around x/y)
        //transform.forward gets forward relative to the way transform is facing 
        if(up) {
            transform.Translate(Vector3.forward * effectivespeed * Time.deltaTime);
        }
        if(down) {
            transform.Translate(Vector3.back * effectivespeed * Time.deltaTime);
        }
        if(left) {
            transform.Translate(Vector3.left * effectivespeed * Time.deltaTime);
        }
        if(right) {
            transform.Translate(Vector3.right * effectivespeed * Time.deltaTime);
        }

        //never let the player leave the ground 
        if(transform.position.y != initialy) {
            transform.position = new Vector3(transform.position.x, initialy, transform.position.z);
        }

        //dont let the player float either 
        GetComponent<Rigidbody>().velocity = Vector3.zero;

    }
}
