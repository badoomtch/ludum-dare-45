using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTheMoon : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trying to go to the moon");
        AudioManager.GetInstance().FadeMusicOut(1f);
        SceneManager.LoadScene("Level02");
    }
}
