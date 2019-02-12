using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorDisplay : MonoBehaviour
{
    public Text mode;
    
    public string mode1;
    public string mode2;
    public string mode3;
    public string mode4;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void Red()
    {
        mode.text = mode2;
        mode.color = Color.red;
    }

    public void Blue()
    {
        mode.text = mode1;
        mode.color = Color.blue;
    }

    public void Yellow()
    {
        mode.text = mode3;
        mode.color = Color.yellow;
    }

    public void White()
    {
        mode.text = mode4;
        mode.color = Color.white;
    }
    
}
