using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightTrigger : MonoBehaviour
{

    public GameObject lightToTurnOn;


    void Start()
    {
       

        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Lever")
        {

            Light myLight = lightToTurnOn.GetComponent<Light>();

            myLight.enabled = true;

           AudioSource lightAudio = lightToTurnOn.GetComponent<AudioSource>();
            lightAudio.Play();



            Debug.Log("HIT");
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.tag == "Lever")
        {
            Light myLight = lightToTurnOn.GetComponent<Light>();

            myLight.enabled = false;

            AudioSource lightAudio = lightToTurnOn.GetComponent<AudioSource>();
            lightAudio.Play();

            Debug.Log("Released");
        }
    }

    
    

}
