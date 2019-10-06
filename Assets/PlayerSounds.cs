using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    bool grounded;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (grounded == true)
            {
                AudioManager.GetInstance().PlaySoundOnce("Jump");
                grounded = false;
            }
            else
            {
                Debug.Log("Your are jumping");
            }
        }



        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            AudioManager.GetInstance().PlaySoundLoop("Walking");
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            AudioManager.GetInstance().PlaySoundLoop("Walking");
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            AudioManager.GetInstance().PlaySoundLoop("Walking");
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            AudioManager.GetInstance().PlaySoundLoop("Walking");
        }


        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            AudioManager.GetInstance().StopSoundLoop("Walking");
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            AudioManager.GetInstance().StopSoundLoop("Walking");
        }
        if (Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        {
            AudioManager.GetInstance().StopSoundLoop("Walking");
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            AudioManager.GetInstance().StopSoundLoop("Walking");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (!grounded)
            {
                AudioManager.GetInstance().StopSoundLoop("Walking");
                AudioManager.GetInstance().PlaySoundLoop("Running");
            }
            
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            AudioManager.GetInstance().StopSoundLoop("Walking");
            AudioManager.GetInstance().StopSoundLoop("Running");
        }


    }




    private void OnCollisionEnter(Collision collision)
    {
        grounded = true;
    }
}
