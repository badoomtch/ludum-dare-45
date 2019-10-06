using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeTrigger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        AudioManager.GetInstance().FadeMusicOut(1f);
        SceneManager.LoadScene("Level03");
    }
}
