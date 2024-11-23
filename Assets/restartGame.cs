using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class restartGame : MonoBehaviour
{

    public GameObject FadeOut;
    public Animation musicFade;

    public void RestartGame()
    {
        FadeOut.SetActive(true);

        StartCoroutine(WaitForRestart());

    }

    IEnumerator WaitForRestart()
    {

        Destroy(GameObject.FindWithTag("Manager"));

        yield return new WaitForSeconds(6);
        SceneManager.LoadSceneAsync(0);


    }
}
