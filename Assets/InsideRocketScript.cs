using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InsideRocketScript : MonoBehaviour
{
    public GameObject asteroid;
    public GameObject explosion;

    public GameObject fadeToBlack;
    public GameObject computertext;
    public GameObject warningLights;
    public GameObject warningText;
    public GameObject payloadText;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlaySoundLoop("RocketHum");
        TextOnScreen.FindObjectOfType<TextOnScreen>().Text8();
        StartCoroutine(Asteroid(15));
        StartCoroutine(Explode(20));
        StartCoroutine(LoadNextScene(32));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Asteroid(float duration)
    {
        yield return new WaitForSeconds(duration);
        asteroid.SetActive(true);
        TextOnScreen.FindObjectOfType<TextOnScreen>().Text9();
        AudioManager.GetInstance().PlaySoundLoop("WarningBeep");
        warningLights.SetActive(true);
        computertext.SetActive(false);
        warningText.SetActive(true);
        payloadText.SetActive(false);
    }
    IEnumerator Explode(float duration)
    {
        yield return new WaitForSeconds(duration);
        AudioManager.GetInstance().StopSoundLoop("RocketHum");
        AudioManager.GetInstance().StopSoundLoop("WarningBeep");
        AudioManager.GetInstance().PlaySoundOnce("Explosion");
        Instantiate(explosion, new Vector3(0F, 465.8f, 538.8f), Quaternion.identity);
        asteroid.SetActive(false);
        fadeToBlack.SetActive(true);
    }

    IEnumerator LoadNextScene(float duration)
    {
        yield return new WaitForSeconds(duration);
        SceneManager.LoadScene("Level04");
    }
}
