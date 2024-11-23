using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEndState : MonoBehaviour
{
    public bool HikerDiedRangerDied;
    public bool HikerDiedRangerLived;
    public bool HikerLivedRangerDied;
    public bool HikerLivedRangerLived;

    // Start is called before the first frame update
    void Start()
    {
        HikerDiedRangerDied = false;
        HikerDiedRangerLived = false;
        HikerLivedRangerDied = false;
        HikerLivedRangerLived = false;
    }


    void Update()
    {
        if (HikerDiedRangerDied == true)
        {
            PlayerPrefs.SetInt("HikerDRangerD", HikerDiedRangerDied ? 1:0);
        }

        if (HikerDiedRangerLived == true)
        {
            PlayerPrefs.SetInt("HikerDRangerL", HikerDiedRangerLived ? 1:0);
        }

        if (HikerLivedRangerDied == true)
        {
            PlayerPrefs.SetInt("HikerLRangerD", HikerLivedRangerDied ? 1 : 0);
        }

        if (HikerLivedRangerLived == true)
        {
            PlayerPrefs.SetInt("HikerLRangerL", HikerLivedRangerLived ? 1 : 0);
        }
    }

}
