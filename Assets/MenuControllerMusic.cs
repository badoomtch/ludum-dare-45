using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuControllerMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.GetInstance().PlayMusic("MainTheme");
    }

  
}
