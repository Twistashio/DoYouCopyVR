using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class buttonPressed : MonoBehaviour
{

    public float deadTime = 1.0f;

    private bool deadTimeActive = false;
    public bool stillHeld = false;

    public UnityEvent onPressed, onReleased;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Button" && !deadTimeActive)
        {
            stillHeld = true;
            onPressed.Invoke();
            Debug.Log("I have been pressed");


        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Button" && !deadTimeActive)
        {
            stillHeld = false;
            onReleased.Invoke();
            Debug.Log("I have been released");
            StartCoroutine(WaitForDeadTime());
        } else
        {
            Debug.Log("Dead Time Already Active.... Please Wait");
        }
    }


    IEnumerator WaitForDeadTime()
    {
        deadTimeActive = true;
        yield return new WaitForSeconds(deadTime);
        deadTimeActive = false;
    }

}
