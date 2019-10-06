using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DestroyTextArea : MonoBehaviour
{
    public GameObject door;
    public GameObject nothingWord;
    public GameObject player;
    public GameObject destroyText;
    public GameObject destroyedText;
    public GameObject dragUI;

    private void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Nothing2")
        {
            Debug.Log("Nothing is here!");
            Destroy(nothingWord);
            destroyText.SetActive(false);
            destroyedText.SetActive(true);
            AudioManager.GetInstance().PlaySoundOnce("DoorOpening1");
            door.transform.localPosition = new Vector3(-10, 5.5f, -65);
            door.transform.Rotate(0, 45, 0);
            player.GetComponent<Draggable>().enabled = false;
            dragUI.SetActive(false);
        }
    }

}
