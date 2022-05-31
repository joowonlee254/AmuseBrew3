using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingStage :  PlayerScemeManage
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLAYER"))
        {
            StartCoroutine(LoadScene());
        }
    }
    IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(3.0f);
        if (TrueEndOn)
            SceneManager.LoadScene(5);
        else
            SceneManager.LoadScene(4);


    }
}
