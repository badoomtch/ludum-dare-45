using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoonMannager : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        TextOnScreen.FindObjectOfType<TextOnScreen>().Text5();
        AudioManager.GetInstance().PlayMusic("MoonTheme");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
