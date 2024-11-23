using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startGame : MonoBehaviour
{
    public AudioSource menuMusic;
    public GameObject FadeOut;
    public Animation musicFade;

    public void StartGame()
    {
        FadeOut.SetActive(true);
        StartCoroutine(FadeAudioSource.StartFade(menuMusic, 5f, 0f));
        StartCoroutine(WaitForRestart());

    }

    IEnumerator WaitForRestart()
    {

        Destroy(GameObject.FindWithTag("Manager"));

        yield return new WaitForSeconds(6);
        SceneManager.LoadSceneAsync(1);


    }
}
