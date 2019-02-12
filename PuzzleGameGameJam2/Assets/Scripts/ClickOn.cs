using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOn : MonoBehaviour
{
   
    public GameObject Player;
    private Material mat;
    


    public void ClickMe()
    {
        
        if(gameObject.CompareTag("Red"))
        {
            Player.GetComponent<ColorPicker>().RedColor();
            Player.GetComponent<ColorDisplay>().Red();
        }
        else if (gameObject.CompareTag("Blue"))
        {
            Player.GetComponent<ColorPicker>().BlueColor();
            Player.GetComponent<ColorDisplay>().Blue();
        }
        else if(gameObject.CompareTag("Yellow"))
        {
            Player.GetComponent<ColorPicker>().YellowColor();
            Player.GetComponent<ColorDisplay>().Yellow();
        }
        else if(gameObject.CompareTag("White"))
        {
            Player.GetComponent<ColorPicker>().WhiteColor();
            Player.GetComponent<ColorDisplay>().White();

        }
        
    }
}
