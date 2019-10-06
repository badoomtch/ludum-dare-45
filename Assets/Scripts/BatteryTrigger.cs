using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTrigger : MonoBehaviour
{
    public GameObject battery;
    public GameObject laser;
    public GameObject rocketBomb;

    public GameObject explosion;
    bool isExploded = false;

    public GameObject homeTrigger;

    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.name == "Battery")
        {
            TextOnScreen.FindObjectOfType<TextOnScreen>().Text6();
            AudioManager.GetInstance().PlaySoundOnce("Battery");
            StartCoroutine(LaserSound(1));
            StartCoroutine(Laser(5));
        }
    }


    IEnumerator LaserSound (float duration)
    {
        yield return new WaitForSeconds(duration);
        AudioManager.GetInstance().PlaySoundOnce("Laser");
    }
    IEnumerator Laser(float duration)
    {
        yield return new WaitForSeconds(duration);
        laser.SetActive(true);
        Destroy(laser, 3);
        Destroy(rocketBomb, 3);
        StartCoroutine(Explosion(3));
    }

    IEnumerator Explosion(float duration)
    {
        yield return new WaitForSeconds(duration);
        if (!isExploded)
        {
            AudioManager.GetInstance().PlaySoundOnce("Explosion");
            Instantiate(explosion, new Vector3(181.77f, 603.61f, 1090f), Quaternion.identity);
            isExploded = true;
            TextOnScreen.FindObjectOfType<TextOnScreen>().Text7();
            homeTrigger.SetActive(true);
        }
    }
}