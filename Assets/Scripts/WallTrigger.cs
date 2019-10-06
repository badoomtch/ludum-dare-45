using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public float moveSpeed = 100;
    public GameObject wall1;
    public GameObject wall2;

    public GameObject destroyText;
    private void OnTriggerEnter(Collider other)
    {
        wall1.transform.position = new Vector3(-1, 5, -29);
        wall2.SetActive(true);
        destroyText.SetActive(true);
        Destroy(gameObject);
    }
}
