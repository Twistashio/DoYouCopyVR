using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newspaperHandler : MonoBehaviour
{
    public GameObject fadeIN;

    public GameObject newspaper1;
    public GameObject newspaper2;
    public GameObject newspaper3;
    public GameObject newspaper4;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(hideFade());

        StartCoroutine(endStateCheck());

        newspaper1.SetActive(false);
        newspaper2.SetActive(false);
        newspaper3.SetActive(false);
        newspaper4.SetActive(false);


    }

    IEnumerator endStateCheck()
    {
        yield return new WaitForSeconds(4);
        GameObject myManager = GameObject.FindWithTag("Manager");


        if (myManager.GetComponent<GameEndState>().HikerDiedRangerDied == true)
        {
            newspaper1.SetActive(true);
        }
        else if (myManager.GetComponent<GameEndState>().HikerDiedRangerLived == true)
        {
            newspaper2.SetActive(true);
        }
        else if (myManager.GetComponent<GameEndState>().HikerLivedRangerDied == true)
        {
            newspaper4.SetActive(true);
        }
        else if (myManager.GetComponent<GameEndState>().HikerLivedRangerLived == true)
        {
            newspaper3.SetActive(true);
        }
    }


    IEnumerator hideFade()
    {
        yield return new WaitForSeconds(5);
        fadeIN.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
