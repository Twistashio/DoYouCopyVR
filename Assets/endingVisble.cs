using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endingVisble : MonoBehaviour
{

    public int ending1;
    public int ending2;
    public int ending3;
    public int ending4;

    public GameObject endingOne;
    public GameObject endingTwo;
    public GameObject endingThree;
    public GameObject endingFour;
    public GameObject endingOneQ;
    public GameObject endingTwoQ;
    public GameObject endingThreeQ;
    public GameObject endingFourQ;



    // Start is called before the first frame update
    void Start()
    {
        endingOne.SetActive(false);
        endingTwo.SetActive(false);
        endingThree.SetActive(false);
        endingFour.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        ending1 = PlayerPrefs.GetInt("HikerDRangerD");

        ending2 = PlayerPrefs.GetInt("HikerDRangerL");

        ending3 = PlayerPrefs.GetInt("HikerLRangerL");

        ending4 = PlayerPrefs.GetInt("HikerLRangerD");




        if (ending1 == 1)
        {
            endingOne.SetActive(true);
            endingOneQ.SetActive(false);
        }

        if (ending2 == 1)
        {
            endingTwo.SetActive(true);
            endingTwoQ.SetActive(false);
        }

        if (ending3 == 1)
        {
            endingThree.SetActive(true);
            endingThreeQ.SetActive(false);
        }

        if (ending4 == 1)
        {
            endingFour.SetActive(true);
            endingFourQ.SetActive(false);
        }
    }

    public void resetPlayerPrefs()
    {
        PlayerPrefs.DeleteAll();
        endingOne.SetActive(false);
        endingTwo.SetActive(false);
        endingThree.SetActive(false);
        endingFour.SetActive(false);
        endingOneQ.SetActive(true);
        endingTwoQ.SetActive(true);
        endingThreeQ.SetActive(true);
        endingFourQ.SetActive(true);
    }
}
