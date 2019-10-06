using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NothingPuzzle : MonoBehaviour
{
    public GameObject explosion;
    bool hasExploded = false;

    public GameObject rocket;
    public ParticleSystem smoke;
    private Animation rocketAnim;

    public GameObject door;
    public GameObject secretDoor;
    public GameObject rocket2;
    bool doorIsOpen = false;

    public TextMeshProUGUI letter1;
    public TextMeshProUGUI letter2;
    public TextMeshProUGUI letter3;
    public TextMeshProUGUI letter4;
    public TextMeshProUGUI letter5;
    public TextMeshProUGUI letter6;
    public TextMeshProUGUI letter7;

    string[] array1 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array2 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array3 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array4 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array5 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array6 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    string[] array7 = { "a", "b", "c", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
    int arrayPos1 = 0;
    int arrayPos2 = 0;
    int arrayPos3 = 0;
    int arrayPos4 = 0;
    int arrayPos5 = 0;
    int arrayPos6 = 0;
    int arrayPos7 = 0;

    private void Start()
    {
        smoke = GetComponent<ParticleSystem>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos1 >= array1.Length - 1)
            {
                arrayPos1 = 0;
            }
            else
            {
                arrayPos1 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos2 >= array2.Length - 1)
            {
                arrayPos2 = 0;
            }
            else
            {
                arrayPos2 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos3 >= array3.Length - 1)
            {
                arrayPos3 = 0;
            }
            else
            {
                arrayPos3 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos4 >= array4.Length - 1)
            {
                arrayPos4 = 0;
            }
            else
            {
                arrayPos4 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos5 >= array5.Length - 1)
            {
                arrayPos5 = 0;
            }
            else
            {
                arrayPos5 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos6 >= array6.Length - 1)
            {
                arrayPos6 = 0;
            }
            else
            {
                arrayPos6 += 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            AudioManager.GetInstance().PlaySoundOnce("Keyboard");
            if (arrayPos7 >= array7.Length - 1)
            {
                arrayPos7 = 0;
            }
            else
            {
                arrayPos7 += 1;
            }
        }


        letter1.text = array1[arrayPos1].ToString();
        letter2.text = array2[arrayPos2].ToString();
        letter3.text = array3[arrayPos3].ToString();
        letter4.text = array4[arrayPos4].ToString();
        letter5.text = array5[arrayPos5].ToString();
        letter6.text = array6[arrayPos6].ToString();
        letter7.text = array7[arrayPos7].ToString();

        if (array1[arrayPos1] == "n"
            && array2[arrayPos2] == "o"
            && array3[arrayPos3] == "t"
            && array4[arrayPos4] == "h"
            && array5[arrayPos5] == "i"
            && array6[arrayPos6] == "n"
            && array7[arrayPos7] == "g"
            )
        {
            Debug.Log("You have n!");
            
            if (!hasExploded)
            {
                Instantiate(explosion, new Vector3(-16.1F, 40.93f, -125.03f), Quaternion.identity);
                hasExploded = true;
                TextOnScreen.FindObjectOfType<TextOnScreen>().Text4();
                AudioManager.GetInstance().PlaySoundOnce("Explosion");
                AudioManager.GetInstance().PlaySoundOnce("RocketLaunch");
                rocket.SetActive(true);
                smoke.Play();
                Destroy(rocket, 15);
                
            }
            if (!doorIsOpen)
            {
                Debug.Log("Tried to open door");
                door.transform.Rotate(0, 68.92f, 0);
                secretDoor.SetActive(false);
                rocket2.SetActive(true);
                doorIsOpen = true;
            }

        }

        //if (Input.GetKeyDown(KeyCode.F))
        //{
        //    Instantiate(explosion, new Vector3(-16.1F, 40.93f, -125.03f), Quaternion.identity);
        //}

    }
}
