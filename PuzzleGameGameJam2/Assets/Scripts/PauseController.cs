using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // Add this to use Text features

public class PauseController : MonoBehaviour
{

    // GET TEXT BOXES
    public Text Menu;

    // SET VARIABLES
    public bool isPaused;

    void Start()
    {
        // Pause the game on start
        Time.timeScale = 0;
        isPaused = true;

        // Display the initial menu
        Menu.text = "PIXEL PUZZLE\nMatch the pattern on the floor to the pattern on the wall." +
        	"\nPress the H, J, K, L keys to change paint color\n" +
            "H = Red, J = Blue, K = Yellow, L = White\nPress P to Play/Pause.";
    }

    // Update is called once per frame
    void Update()
    {
        // PAUSE FUNCTION 
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (!isPaused)
            {
                Time.timeScale = 0;     // PAUSE TIME
                isPaused = true;
                Menu.text = "PAUSED\nPress the H, J, K, L keys to change paint color\n" +
                    "H = Red, J = Blue, K = Yellow, L = White\nPress P to Play/Pause.";
            }
            else
            {
                Time.timeScale = 1;     // UNPAUSE TIME
                Menu.text = "";
                isPaused = false;
            }
        }
    }
}