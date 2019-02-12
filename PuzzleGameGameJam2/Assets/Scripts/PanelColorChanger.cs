using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelColorChanger : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Renderer rend;
    public int PanelID;

    // DEFINE NEW COLORS
    Color purple = new Vector4(0.6f, 0f, 1f, 1f);
    Color orange = new Vector4(1F, 0.4F, 0F, 1f);
    Color brown = new Vector4(0.5f, 0.27f, 0.07f, 1f);

    void Start()
    {
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
        //Set the initial color to white
        rend.material.color = Color.white;
    }

    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        // BULLET COLLIDES WITH PANEL, CHANGE COLOR
        // BULLETS MUST BE TAGGED "Bullet" 
        if (other.gameObject.CompareTag("Bullet"))
        {
            // DESTROY THE BULLET
            //Destroy(other);
            other.gameObject.SetActive(false);

            Renderer bulletRend = other.GetComponent<Renderer>();
 
            if (rend.material.color.Equals(Color.white))
            {
                // THE PANEL IS WHITES
                // SET PANEL TO BULLET COLOR
                //rend.material.color = bulletRend.material.color;

                if (bulletRend.material.color.Equals(Color.blue))
                {
                    // THE BULLET IS BLUE
                    // SET PANEL TO BLUE
                    rend.material.color = Color.blue;
                }
                else if (bulletRend.material.color.Equals(Color.red))
                {
                    // THE BULLET IS RED
                    // SET PANEL TO RED
                    rend.material.color = Color.red;
                }
                else if (bulletRend.material.color.Equals(Color.yellow))
                {
                    // THE BULLET IS YELLOW
                    // SET THE PANEL TO YELLOW
                    rend.material.color = Color.yellow;
                }
            }
            else if (rend.material.color.Equals(Color.red))
            {
                // PANEL IS RED
                // BLEND PANEL TO BULLET COLOR
                if (bulletRend.material.color.Equals(Color.blue))
                {
                    // THE BULLET IS BLUE
                    // SET PANEL TO PURPLE
                    rend.material.color = purple;

                }
                else if (bulletRend.material.color.Equals(Color.yellow))
                {
                    // THE BULLET IS YELLOW
                    // SET PANEL TO ORANGE
                    rend.material.color = orange;
                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET THE PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            }
            else if (rend.material.color.Equals(Color.yellow))
            {
                // PANEL IS YELLOW
                // BLEND PANEL TO BULLET COLOR
                if (bulletRend.material.color.Equals(Color.blue))
                {
                    // THE BULLET IS BLUE
                    // SET PANEL TO GREEN
                    rend.material.color = Color.green;

                }
                else if (bulletRend.material.color.Equals(Color.red))
                {
                    // THE BULLET IS RED
                    // SET PANEL TO ORANGE
                    rend.material.color = orange;
                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET THE PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            }
            else if (rend.material.color.Equals(Color.blue))
            {
                // PANEL IS BLUE
                // BLEND PANEL TO BULLET COLOR
                if (bulletRend.material.color.Equals(Color.yellow))
                {
                    // THE BULLET IS YELLOW
                    // SET PANEL TO GREEN
                    rend.material.color = Color.green;

                }
                else if (bulletRend.material.color.Equals(Color.red))
                {
                    // THE BULLET IS RED
                    // SET PANEL TO PURPLE
                    rend.material.color = purple;
                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET THE PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            } 
            else if (rend.material.color.Equals(purple)) 
            {
                // PANEL IS PURPLE
                if (bulletRend.material.color.Equals(Color.yellow))
                {
                    // THE BULLET IS YELLOW
                    // SET PANEL TO GREY
                    rend.material.color = brown;

                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            }
            else if (rend.material.color.Equals(orange))
            {
                // PANEL IS ORANGE
                if (bulletRend.material.color.Equals(Color.blue))
                {
                    // THE BULLET IS BLUE
                    // SET PANEL TO GREY
                    rend.material.color = brown;

                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            }
            else if (rend.material.color.Equals(Color.green))
            {
                // PANEL IS GREEN
                if (bulletRend.material.color.Equals(Color.red))
                {
                    // THE BULLET IS RED
                    // SET PANEL TO GREY
                    rend.material.color = brown;

                }
                else if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET PANEL TO WHITE
                    rend.material.color = Color.white;
                }
            }
            else if (rend.material.color.Equals(brown))
            {
                // PANEL IS GREY
                if (bulletRend.material.color.Equals(Color.white))
                {
                    // THE BULLET IS WHITE
                    // SET PANEL TO WHITE
                    rend.material.color = Color.white;

                }
            }
        }

    } // END OnTriggerEnter
}
