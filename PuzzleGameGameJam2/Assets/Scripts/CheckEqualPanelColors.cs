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

        for (int i = 0; i < floorPanels.Length; i++)
        {
            if (i % 3 == 0)
            {
                floorPanels[i].GetComponent<Renderer>().material.color = Color.yellow;
            }
            else if (i % 3 == 1)
            {
                floorPanels[i].GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                floorPanels[i].GetComponent<Renderer>().material.color = Color.blue;
            }
        }
    }
        // Update is called once per frame
        void Update()
        {

            //Simple for loop checking if the color of all the panels on the floor and the wall are equal
            for (int i = 0; i < wallPanels.Length && i < floorPanels.Length; i++)
            {
                if (wallPanels[i].GetComponent<Renderer>().material.color.Equals(floorPanels[i].GetComponent<Renderer>().material.color))
                {
                    numbOfPanelsTheSame++;
                }
            }

            //Game is won if all the panel colors match up
            if (numbOfPanelsTheSame == 25)
            {
                Application.Quit();    //Reloads the game

            }
        }
 }

