using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Draggable : MonoBehaviour
{

    public float interactionDistance = 3f;
    public bool imnear;
    public Rigidbody rb;
    public GameObject player;
    public float pushforce = 200f;


    public GameObject MouseTip;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(transform.position, transform.forward * interactionDistance);

        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance))
        {
            imnear = (hit.collider.tag == "Word");
            if (imnear)
            {
                MouseTip.gameObject.SetActive(true);
            }
            if (Physics.Raycast(transform.position, transform.forward, out hit, interactionDistance) && Input.GetMouseButtonDown(0))
            {
                if (hit.rigidbody)
                {
                    AudioManager.GetInstance().PlaySoundOnce("Tap");
                    hit.rigidbody.AddForceAtPosition(200 * transform.forward, hit.point);
                }
                    
            }
            if (Physics.Raycast(transform.position, player.transform.forward, out hit, interactionDistance) && Input.GetMouseButtonDown(1))
            {
                if (hit.rigidbody)
                {
                    AudioManager.GetInstance().PlaySoundOnce("Tap");
                    hit.rigidbody.AddForceAtPosition(200 * -player.transform.forward, hit.point);
                }
            }
        }
        else
        {
            MouseTip.gameObject.SetActive(false);
        }


        
    }
}



