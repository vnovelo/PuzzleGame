using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelPatternGen : MonoBehaviour
{
    public GameObject[] PanelArray = new GameObject[9];
    //public GameObject[] PanelsSorted = new GameObject[9];

    void Start()
    {
        PanelArray = GameObject.FindGameObjectsWithTag("Panel");

        foreach (GameObject panel in PanelArray)
        {
            PanelColorChanger PanelScript = panel.GetComponent<PanelColorChanger>();

            //Debug.Log(PanelScript.PanelID);

            //PanelsSorted[PanelScript.PanelID] = panel;
        }
    }

    // Update is called once per frame
    void Update()
    {
        foreach (GameObject panel in PanelArray)
        {
            Renderer panelRend = panel.GetComponent<Renderer>();

            //panelRend.material.color = Color.blue;

            PanelColorChanger PanelScript = panel.GetComponent<PanelColorChanger>();


            Debug.Log(PanelScript.PanelID);
            Debug.Log(panel.GetComponent<Renderer>().material.color);

        }
    }
}
