using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTrigger : MonoBehaviour
{
    public GameObject door;
    public GameObject room;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("You're in the room");
        door.transform.localPosition = new Vector3(-10.63f, 5.52f, -65);
        AudioManager.GetInstance().PlaySoundOnce("DoorClosing1");
        door.transform.Rotate(0, -45, 0);
        room.SetActive(true);
        Destroy(gameObject);
    }
}
