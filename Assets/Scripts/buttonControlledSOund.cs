using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonControlledSOund : MonoBehaviour
{
    public int npcWaitTime;

    public AudioSource music1;
    public AudioSource music2;
    public AudioSource music3;
    public AudioSource music4;
    public AudioSource music5;
    public AudioSource tension;

    public AudioSource treeBreaking;



    public AudioSource radio;
    public AudioSource hourCheckResponse;
    public AudioSource anyOneThere;
    public AudioSource firstHelpCall;
    public AudioSource imGoingToDie;
    public AudioSource letThereBeLight;
    public AudioSource whatEverYouDo;
    public AudioSource firstBreak;
    public AudioSource notHikersVoice;
    public AudioSource goesLeft;
    public AudioSource goesRight;
    public AudioSource hikerScaredOfNothing;
    public AudioSource noDidYouSeeThat;
    public AudioSource notATree;
    public AudioSource chasedFromPath;
    public AudioSource landmarksAround;
    public AudioSource oweYouOne;
    public AudioSource doesCreeps;
    public AudioSource yeah;
    public AudioSource someOneWatching;
    public AudioSource forkInRoadforWIN;
    public AudioSource gracewinSplit;
    public AudioSource thankYOU;






    public AudioSource monsterS1;
    public AudioSource monsterScream;
    public AudioSource oneMistake;
    public AudioSource monsterSaveHim;
    public AudioSource areYouWatchingTheLake;
    public AudioSource doYouSeeMe;
    public AudioSource knowWhereImGoing;
    public AudioSource notAloneOutHere;
    public AudioSource makeItRun;
    public AudioSource forkInRoadForLost;
    public AudioSource seeYouSoon;
    public AudioSource jumpScare;



    public GameObject tower2;
    public Light spotLight;

    public GameObject gameEndStates;
    public GameObject physicsButton;
    public GameObject optionSelect;
    public GameObject lightRay;
    public GameObject lakeEyes;
    public GameObject clsoeEyes;
    public GameObject birds;
    public GameObject monsterJumpScare;
    public GameObject fadeOut;
    public GameObject fadeIN;




    public GameObject guiButton1;
    public GameObject guiButton2;
    public GameObject guiButton3;
    public GameObject guiButton4;
    public GameObject guiButton5;
    public GameObject guiButton6;
    public GameObject guiButton7;
    public GameObject guiButton8;
    public GameObject guiButton9;
    public GameObject guiButton10;
    public GameObject guiButton11;
    public GameObject guiButton12;
    public GameObject guiButton13;
    public GameObject guiButton14;
    public GameObject guiButton15;
    public GameObject guiButton16;




    private bool myLight;
    private bool playedOnce = false;
    private bool playedOnce2 = false;
    private bool doneOnce = false;
    private bool isLightActive = false;
    private bool wentLake = false;
    private bool lightWasActive = false;
    private bool showSignActive = false;
    private bool sleep = false;


    private int counter = 0;
    private int storyBeat = 0;

    // Start is called before the first frame update
    private void Start()
    {

        guiButton1.SetActive(false);
        guiButton2.SetActive(false);
        guiButton3.SetActive(false);
        guiButton4.SetActive(false);
        guiButton5.SetActive(false);
        guiButton6.SetActive(false);
        guiButton7.SetActive(false);
        guiButton8.SetActive(false);
        guiButton9.SetActive(false);
        guiButton10.SetActive(false);
        guiButton11.SetActive(false);
        guiButton12.SetActive(false);
        guiButton13.SetActive(false);
        guiButton14.SetActive(false);
        guiButton15.SetActive(false);
        guiButton16.SetActive(false);


        lightRay.SetActive(false);
        lakeEyes.SetActive(false);
        clsoeEyes.SetActive(false);
        birds.SetActive(false);
        monsterJumpScare.SetActive(false);



        tower2.SetActive(true);
        StartCoroutine(SoundsStart());
        StartCoroutine(hideFade());
    }

    public void ButtonCount()
    {
        /*if (physicsButton.GetComponent<buttonPressed>().stillHeld == true)
        {
            Canvas userGUI = optionSelect.GetComponent<Canvas>();

            userGUI.enabled = true;
        } else
        {
            Canvas userGUI = optionSelect.GetComponent<Canvas>();

            userGUI.enabled = false;
        } 
        
        if (guiButton1.activeInHierarchy == false && counter == 1)
        {
            PlayAudioSequence("Tower Two. This is Tower 4. I Copy. Over.");
        } else if (guiButton2.activeInHierarchy == false && guiButton3.activeInHierarchy == false && counter == 2)
        {
            PlayAudioSequence("Say Nothing...");
        }
        */

    }

    public void PlayAudioSequence(string buttonText)
    {
        Debug.Log("calling");
        Debug.Log(counter);

        if (string.Equals(buttonText, "Tower Two. This is Tower 4. I Copy. Over."))
        {
            guiButton1.SetActive(false);

        }
        else if (string.Equals(buttonText, "This Is Tower 4. Over.") || string.Equals(buttonText, "Say Nothing..."))
        {
            guiButton2.SetActive(false);
            guiButton3.SetActive(false);
        }
        else if (string.Equals(buttonText, "Calm down. You need to stay calm. Where are you? Over.") || string.Equals(buttonText, "What do you mean? What's chasing you? Over."))
        {
            guiButton4.SetActive(false);
            guiButton5.SetActive(false);
        }
        else if (string.Equals(buttonText, "I'll turn the flood light on. Over."))
        {
            guiButton6.SetActive(false);

        }



        if (counter == 1 && string.Equals(buttonText, "Tower Two. This is Tower 4. I Copy. Over."))
        {


            hourCheckResponse.Play();

            StartCoroutine(HikerVoice());
        }
        else if (counter == 2 && string.Equals(buttonText, "This Is Tower 4. Over.") || counter == 2 && string.Equals(buttonText, "Say Nothing..."))
        {
            firstHelpCall.Play();
            storyBeat = storyBeat + 1;



            StartCoroutine(HikerVoice2());

        }
        else if (counter == 3 && string.Equals(buttonText, "Calm down. You need to stay calm. Where are you? Over.") || counter == 3 && string.Equals(buttonText, "What do you mean? What's chasing you? Over."))
        {
            imGoingToDie.Play();

            storyBeat = storyBeat + 1;

            if (counter < storyBeat)
            {
                counter = counter + 1;
            }

            StartCoroutine(LightPromt());


        }
        else if (counter == 4 && string.Equals(buttonText, "Take The Left Path. Over.") || counter == 4 && string.Equals(buttonText, "Take The RIght Path. Over."))
        {

            guiButton1.SetActive(false);
            guiButton2.SetActive(false);
            guiButton3.SetActive(false);
            guiButton4.SetActive(false);
            guiButton5.SetActive(false);
            guiButton6.SetActive(false);
            guiButton7.SetActive(false);
            guiButton8.SetActive(false);
            guiButton9.SetActive(false);
            guiButton10.SetActive(false);
            guiButton11.SetActive(false);
            guiButton12.SetActive(false);
            guiButton13.SetActive(false);
            guiButton14.SetActive(false);
            guiButton15.SetActive(false);
            guiButton16.SetActive(false);
            guiButton7.SetActive(false);
            guiButton8.SetActive(false);

            if (string.Equals(buttonText, "Take The Left Path. Over."))
            {
                goesLeft.Play();
                StartCoroutine(MonsterFirstApperanceONE());
            }
            else
            {
                goesRight.Play();
                StartCoroutine(MonsterFirstApperanceTWO());
            }
        }
        else if (counter == 5 && string.Equals(buttonText, "What Was That... Over."))
        {

            guiButton9.SetActive(false);

            StartCoroutine(HikerNotVoice());

        }
        else if (counter == 6 && string.Equals(buttonText, "Just keep on the path, okay? You're almost here.") || counter == 6 && string.Equals(buttonText, "It's just a tree falling. Don't worry about it."))
        {

            guiButton10.SetActive(false);
            guiButton11.SetActive(false);

            if (string.Equals(buttonText, "Just keep on the path, okay? You're almost here."))
            {
                StartCoroutine(HikerMaybeSeriousONE());
            }
            else
            {
                StartCoroutine(HikerMaybeSeriousTWO());
            }
        }
        else if (counter == 7 && string.Equals(buttonText, "Any Landmarks around? Over."))
        {
            guiButton1.SetActive(false);
            guiButton2.SetActive(false);
            guiButton3.SetActive(false);
            guiButton4.SetActive(false);
            guiButton5.SetActive(false);
            guiButton6.SetActive(false);
            guiButton7.SetActive(false);
            guiButton8.SetActive(false);
            guiButton9.SetActive(false);
            guiButton10.SetActive(false);
            guiButton11.SetActive(false);
            guiButton12.SetActive(false);
            guiButton13.SetActive(false);
            guiButton14.SetActive(false);
            guiButton15.SetActive(false);
            guiButton16.SetActive(false);

            StartCoroutine(LandmarksAround());

        }
        else if (counter == 8 && string.Equals(buttonText, "Head toward the mine. Over.") || counter == 8 && string.Equals(buttonText, "Head toward the lake. Over."))
        {

            guiButton13.SetActive(false);
            guiButton14.SetActive(false);

            if (string.Equals(buttonText, "Head toward the mine. Over."))
            {

                StartCoroutine(HikerVoice4Mines());
            }
            else
            {
                StartCoroutine(HikerVoice5Lake());
            }

        }
        else if (counter == 10 && string.Equals(buttonText, "Take The Left Path. Over.") || counter == 10 && string.Equals(buttonText, "Take The RIght Path. Over."))
        {

            guiButton7.SetActive(false);
            guiButton8.SetActive(false);

            if (string.Equals(buttonText, "Take The Left Path. Over."))
            {
                goesLeft.Play();
                StartCoroutine(MonsterGetsMadGracewind());
            }
            else
            {
                gameEndStates.GetComponent<GameEndState>().HikerDiedRangerDied = true;
                seeYouSoon.Play();

                StartCoroutine(JumpScare());
            }
        }
        else if (counter == 11 && string.Equals(buttonText, "You get used to it over time. Over.") || counter == 11 && string.Equals(buttonText, "It will always be creepy. Over."))
        {

            guiButton1.SetActive(false);
            guiButton2.SetActive(false);
            guiButton3.SetActive(false);
            guiButton4.SetActive(false);
            guiButton5.SetActive(false);
            guiButton6.SetActive(false);
            guiButton7.SetActive(false);
            guiButton8.SetActive(false);
            guiButton9.SetActive(false);
            guiButton10.SetActive(false);
            guiButton11.SetActive(false);
            guiButton12.SetActive(false);
            guiButton13.SetActive(false);
            guiButton14.SetActive(false);
            guiButton15.SetActive(false);
            guiButton16.SetActive(false);

            StartCoroutine(HikerVoice6Mines());


        }
        else if (counter == 12 && string.Equals(buttonText, "Take The Left Path. Over.") || counter == 12 && string.Equals(buttonText, "Take The RIght Path. Over."))
        {

            guiButton7.SetActive(false);
            guiButton8.SetActive(false);

            if (string.Equals(buttonText, "Take The Left Path. Over."))
            {
                goesLeft.Play();
                StartCoroutine(MonsterGetsMadTower());
            }
            else
            {
                StartCoroutine(MonsterKillSMines());

            }
        }
        else if (counter == 13 && string.Equals(buttonText, "Take The Left Path. Over.") || counter == 13 && string.Equals(buttonText, "Take The RIght Path. Over."))
        {

            guiButton7.SetActive(false);
            guiButton8.SetActive(false);

            if (string.Equals(buttonText, "Take The Left Path. Over."))
            {
                gameEndStates.GetComponent<GameEndState>().HikerDiedRangerDied = true;
                seeYouSoon.Play();

                StartCoroutine(JumpScare());
            }
            else
            {

                StartCoroutine(MonsterGetsMadGracewind());

            }

        }
    }

    IEnumerator SoundsStart()
    {
        if (counter == 0)
        {
            yield return new WaitForSeconds(npcWaitTime - 89);
            radio.Play();

            yield return new WaitForSeconds(8);
            guiButton1.SetActive(true);


            storyBeat = storyBeat + 1;


            if (counter < storyBeat)
            {
                counter = counter + 1;
            }
        }
    }

    IEnumerator HikerVoice()
    {
        yield return new WaitForSeconds(11);
        tower2.SetActive(false);

        music1.Play();

        yield return new WaitForSeconds(npcWaitTime - 10);
        anyOneThere.Play();

        yield return new WaitForSeconds(5);
        guiButton2.SetActive(true);
        guiButton3.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }


    }

    IEnumerator HikerVoice2()
    {
        yield return new WaitForSeconds(10);
        guiButton4.SetActive(true);
        guiButton5.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }
    }

    IEnumerator HikerVoice3()
    {
        yield return new WaitForSeconds(10);
        guiButton5.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }
    }

    IEnumerator HikerVoice4Mines()
    {
        sleep = true;

        yield return new WaitForSeconds(1);
        oweYouOne.Play();

        storyBeat = storyBeat + 1;

        yield return new WaitForSeconds(15);
        monsterSaveHim.Play();


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }

        yield return new WaitForSeconds(60);

        doesCreeps.Play();

        yield return new WaitForSeconds(15);

        guiButton15.SetActive(true);
        guiButton16.SetActive(true);


        storyBeat = storyBeat + 2;

        if (counter < storyBeat)
        {
            counter = counter + 2;
        }

    }

    IEnumerator HikerVoice5Lake()
    {
        wentLake = true;

        oweYouOne.Play();
        yield return new WaitForSeconds(13);
        lakeEyes.SetActive(true);
        yield return new WaitForSeconds(3);

        makeItRun.Play();

        yield return new WaitForSeconds(15);

        areYouWatchingTheLake.Play();


        yield return new WaitForSeconds(7);


        lakeEyes.SetActive(false);


        yield return new WaitForSeconds(1);

        monsterScream.Play();

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }


    }

    IEnumerator HikerVoice6Mines()
    {


        yield return new WaitForSeconds(1);

        yeah.Play();


        yield return new WaitForSeconds(10);

        doYouSeeMe.Play();

        yield return new WaitForSeconds(20);

        forkInRoadforWIN.Play();

        yield return new WaitForSeconds(5);

        guiButton7.SetActive(true);
        guiButton8.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }


    }

    IEnumerator HikerNotVoice()
    {
        notHikersVoice.Play();

        yield return new WaitForSeconds(8);
        music3.Play();
        yield return new WaitForSeconds(1);
        tension.Stop();

        yield return new WaitForSeconds(10);
        treeBreaking.Play();
        StartCoroutine(MonsterScream());
        yield return new WaitForSeconds(3);
        birds.SetActive(true);

        yield return new WaitForSeconds(4);
        StartCoroutine(HikerOverreaction());
        yield return new WaitForSeconds(10);
        birds.SetActive(false);


    }

    IEnumerator LightPromt()
    {
        yield return new WaitForSeconds(3);
        guiButton6.SetActive(true);
    }

    IEnumerator HikerOverreaction()
    {


        yield return new WaitForSeconds(4);
        hikerScaredOfNothing.Play();

        yield return new WaitForSeconds(1);
        music4.Play();

        StartCoroutine(LightRayFreak());


        yield return new WaitForSeconds(6);

        guiButton10.SetActive(true);
        guiButton11.SetActive(true);


        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }


    }

    IEnumerator HikerMaybeSeriousONE()
    {


        noDidYouSeeThat.Play();


        yield return new WaitForSeconds(6);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }

        StartCoroutine(HikerRunsAway());
    }

    IEnumerator HikerMaybeSeriousTWO()
    {


        notATree.Play();


        yield return new WaitForSeconds(6);
        music4.Play();

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }

        StartCoroutine(HikerRunsAway());

    }

    IEnumerator HikerRunsAway()
    {
        yield return new WaitForSeconds(30);
        chasedFromPath.Play();

        yield return new WaitForSeconds(10);
        guiButton12.SetActive(true);
    }

    IEnumerator LandmarksAround()
    {


        yield return new WaitForSeconds(1);

        landmarksAround.Play();

        guiButton13.SetActive(true);
        guiButton14.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }
    }

    IEnumerator LightRayFreak()
    {
        yield return new WaitForSeconds(1);
        lightRay.SetActive(true);

        yield return new WaitForSeconds(5);
        lightRay.SetActive(false);

    }



    IEnumerator MusicInvestigate()
    {
        yield return new WaitForSeconds(3);
        music2.Play();

        yield return new WaitForSeconds(31);
        whatEverYouDo.Play();

        yield return new WaitForSeconds(70);
        firstBreak.Play();

        yield return new WaitForSeconds(6);
        guiButton7.SetActive(true);
        guiButton8.SetActive(true);

    }


    IEnumerator MonsterFirstApperanceONE()
    {
        yield return new WaitForSeconds(25);
        tension.Play();

        monsterS1.Play();

        yield return new WaitForSeconds(5);
        music5.Play();

        guiButton9.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }
    }

    IEnumerator MonsterFirstApperanceTWO()
    {
        yield return new WaitForSeconds(25);
        tension.Play();

        oneMistake.Play();


        yield return new WaitForSeconds(2);

        music5.Play();

        clsoeEyes.SetActive(true);


        yield return new WaitForSeconds(5);

        clsoeEyes.SetActive(false);

        guiButton9.SetActive(true);

        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }
    }

    IEnumerator MonsterGetsMadGracewind()
    {

        yield return new WaitForSeconds(30);

        knowWhereImGoing.Play();
        showSignActive = true;


        clsoeEyes.SetActive(true);

        yield return new WaitForSeconds(10);

        clsoeEyes.SetActive(false);


    }

    IEnumerator MonsterKillSMines()
    {
        yield return new WaitForSeconds(15);

        areYouWatchingTheLake.Play();


        yield return new WaitForSeconds(7);


        lakeEyes.SetActive(false);


        yield return new WaitForSeconds(1);

        monsterScream.Play();

        StartCoroutine(MonsterLake());
    }

    IEnumerator MonsterGetsMadTower()
    {
        yield return new WaitForSeconds(20);
        notAloneOutHere.Play();

        yield return new WaitForSeconds(25);
        showSignActive = true;


    }

    IEnumerator MonsterLake()
    {
        storyBeat = storyBeat + 1;


        if (counter < storyBeat)
        {
            counter = counter + 1;
        }

        yield return new WaitForSeconds(45);
        gracewinSplit.Play();

        yield return new WaitForSeconds(10);

        guiButton7.SetActive(true);
        guiButton8.SetActive(true);




    }

    IEnumerator MonsterScream()
    {

        yield return new WaitForSeconds(1);
        monsterScream.Play();

        yield return new WaitForSeconds(3);


    }

    IEnumerator NextScen()
    {
        yield return new WaitForSeconds(7);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(2);
    }

    IEnumerator JumpScare()
    {

        int rnd = Random.Range(10, 15);

        yield return new WaitForSeconds(rnd);
        jumpScare.Play();
        monsterJumpScare.SetActive(true);
        yield return new WaitForSeconds(5);
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(2);

    }

    IEnumerator WaitForSign()
    {
        playedOnce2 = true;

        yield return new WaitForSeconds(30);

        playedOnce2 = false;

        if (lightWasActive == true)
        {
            if (wentLake == true)
            {
                gameEndStates.GetComponent<GameEndState>().HikerDiedRangerDied = true;

                StartCoroutine(JumpScare());
            }
            else
            {
                gameEndStates.GetComponent<GameEndState>().HikerLivedRangerDied = true;

                forkInRoadForLost.Play();

                StartCoroutine(JumpScare());


            }
        }
        else
        {

            if (wentLake == true)
            {
                gameEndStates.GetComponent<GameEndState>().HikerDiedRangerLived = true;
                Debug.Log("You Lived, Hiker Died");
                StartCoroutine(NextScen());
            }
            else
            {
                thankYOU.Play();
                gameEndStates.GetComponent<GameEndState>().HikerLivedRangerLived = true;
                StartCoroutine(NextScen());

            }

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

        myLight = spotLight.GetComponent<Light>().enabled;


        if (physicsButton.GetComponent<buttonPressed>().stillHeld == true)
        {
            Canvas userGUI = optionSelect.GetComponent<Canvas>();

            userGUI.enabled = true;
        }
        else
        {
            Canvas userGUI = optionSelect.GetComponent<Canvas>();

            userGUI.enabled = false;
        }

        if (myLight == false)
        {
            isLightActive = false;
        }
        else if (myLight == true)
        {
            isLightActive = true;
        }

        if (counter == 9 && sleep == false)
        {
            sleep = true;
            StartCoroutine(MonsterLake());
        }

        if (counter == 4 && isLightActive == true && playedOnce == false)
        {
            playedOnce = true;
            letThereBeLight.Play();
            StartCoroutine(MusicInvestigate());

        }

        if (showSignActive == true)
        {
            showSignActive = false;
            StartCoroutine(WaitForSign());
        }

        if (playedOnce2 == true && isLightActive == true)
        {
            lightWasActive = true;
        }





    }
}
