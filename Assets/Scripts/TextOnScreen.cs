using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnScreen : MonoBehaviour
{
    public Text mainText;


    public float time = 5; //Seconds to read the text

    private void Awake()
    {
        mainText.text = "";
    }

    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
         if(other.gameObject.name == "WallTrigger1")
        {
            Debug.Log("You hit walltrigger 1");
            Text1();
            StartCoroutine(Wait(5));

        }
        if (other.gameObject.name == "RoomTrigger")
        {
            Debug.Log("You hit room trigger");
            Text3();
            StartCoroutine(Wait(5));
            StartCoroutine(ComputerHint(6));
        }
    }



    public void Text1()
    {
        mainText.text = "You had nothing, and you still have nothing.";
    }
    public void Text2()
    {
        mainText.text = "Will you take your nothing with you, or do you want more?";
    }
    public void Text3()
    {
        mainText.text = "This computer needs nothing from you.";
        
    }
    public void Text4()
    {
        mainText.text = "What have you done?! That wasn't the right password!";
        StartCoroutine(Wait(5));
        StartCoroutine(RocketLaunch(10));
    }
    public void Text5()
    {
        mainText.text = "You made it to the moon before the rocket bomb! Get down there and shoot that ray-gun!";
        StartCoroutine(Wait(10));
    }
    public void Text6()
    {
        mainText.text = "That will do, the ray-gun has started up! Hopefully this works.";
        StartCoroutine(Wait(5));
    }
    public void Text7()
    {
        mainText.text = "Somehow that weird laser actually worked!? Let's get back home. Return to the rocket";
        StartCoroutine(Wait(15));
    }
    public void Text8()
    {
        mainText.text = "We're on course for heading back home. I sure hope nothing goes wrong.";
        StartCoroutine(Wait(10));

    }
    public void Text9()
    {
        mainText.text = "Look out the window! That asteroid is coming right for us!";
        StartCoroutine(Wait(6));
        StartCoroutine(AfterExplosion(10));
    }
    public void Text10()
    {
        mainText.text = "Nothing made you happy, now it's over. The payload has escaped, and you're stuck with it.";
        StartCoroutine(Wait(10));
    }
    public void Text11()
    {
        mainText.text = "Something was on that rocket, and now you get to live with it forever, floating through space.";
        StartCoroutine(Wait(10));
    }
    IEnumerator Wait(float duration)
    {
        yield return new WaitForSeconds(duration);
        mainText.text = "";
    }

    IEnumerator RocketLaunch(float duration)
    {
        yield return new WaitForSeconds(duration);
        mainText.text = "You'll need to go to the moon yourself and stop that rocket. Get out of here and get to the launch site!";
    }

    IEnumerator ComputerHint(float duration)
    {
        yield return new WaitForSeconds(duration);
        mainText.text = "Use the numbers on your keyboard to input the password";
    }
    IEnumerator AfterExplosion(float duration)
    {
        yield return new WaitForSeconds(duration);
        Text10();
    }
}
