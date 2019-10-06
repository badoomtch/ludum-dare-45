using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneScript : MonoBehaviour
{
    public GameObject something;
    public GameObject fadeToBlack;

    void Start()
    {
        AudioManager.GetInstance().PlayMusic("EndTheme");
        AudioManager.GetInstance().StopMusic("MainTheme");
        AudioManager.GetInstance().StopMusic("MoonTheme");
        TextOnScreen.FindObjectOfType<TextOnScreen>().Text11();
        StartCoroutine(fadeout(13));
    }

    IEnumerator ComputerHint(float duration)
    {
        yield return new WaitForSeconds(duration);
        something.SetActive(true);
    }

    IEnumerator fadeout(float duration)
    {
        yield return new WaitForSeconds(duration);
        AudioManager.GetInstance().FadeMusicOut(1f);
        fadeToBlack.SetActive(true);
        StartCoroutine(LoadCredits(3));
    }
    IEnumerator LoadCredits(float duration)
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene("Credits");
    }
}
