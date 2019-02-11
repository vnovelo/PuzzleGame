using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckEqualPanelColors : MonoBehaviour
{


    public GameObject[] wallPanels;
    public GameObject[] floorPanels;


    bool gameWon;              //If true then the Game is won
    int numbOfPanelsTheSame;   //Player wins if 'numOfPanelsTheSame' = 25
    // Start is called before the first frame update
    void Start()
    {
        numbOfPanelsTheSame = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Simple for loop checking if the color of all the panels on the floor and the wall are equal
        for (int i = 0; i < wallPanels.Length && i < floorPanels.Length; i++)
        {
            if (wallPanels[i].GetComponent<Renderer>().material.GetColor("_Color") == floorPanels[i].GetComponent<Renderer>().material.GetColor("_Color"))
            {
                numbOfPanelsTheSame++;
            }
        }

        //Game is won if all the panel colors match up
        if (numbOfPanelsTheSame == 25) gameWon = true;


        if (gameWon)
        {
            //THis will place the 'Game Won' text in the middle of the screen, they re-laod the game after short time delay
            StartCoroutine(displayWonGameText());

        }
    }
    IEnumerator displayWonGameText() {

        //Centers the 'Game Won' text to the center of the Application screen
        var centeredGameWonText = GUI.skin.GetStyle("Label");
        centeredGameWonText.alignment = TextAnchor.UpperCenter;
        GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 25, 100, 50), "Game Won!!!", centeredGameWonText);

        yield return new WaitForSeconds(5); //Waits 5 seconds before reloading the game
        SceneManager.LoadScene(0);          //Reloads the game

    }
}

