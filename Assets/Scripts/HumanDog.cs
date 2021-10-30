using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanDog : MonoBehaviour
{


    //eats wet food
    //sets him upside down or like transforms him so hes flat on the ground 
    //sets vertical scale to 0.5 or rotates him so it looks like hes eating 
    //plays wet food sfx
    //pause
    //fart reverb 
    //pause 
    //hes back after you 

    public AudioClip wetfood;
    public AudioClip fartreverb;

    int feedlength = 100;
    int feedtimer = 0;

    int pauselength = 10;
    int pausetimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
