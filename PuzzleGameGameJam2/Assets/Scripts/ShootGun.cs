using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootGun : MonoBehaviour
{
    public Transform bulletPrefab;
    public Color newColor;
    public Text text;

    void Start()
    {

    }

    void Update()
    {
        //// CHECK FOR COLOR CHANGE
        if (Input.GetKeyDown(KeyCode.H))
        {
            newColor = Color.red;
            text.GetComponent<ColorDisplay>().Red();
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            newColor = Color.blue;
            text.GetComponent<ColorDisplay>().Blue();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            newColor = Color.yellow;
            text.GetComponent<ColorDisplay>().Yellow();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            newColor = Color.white;
            text.GetComponent<ColorDisplay>().White();
        }

        // CHECK IF PLAYER IS FIRING
        if (Input.GetButtonDown("Fire1"))
        {
            // MAKE BULLET, SET DIRECTION FORWARD
            Transform bullet1 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet1.forward = this.transform.forward;

            // SET BULLET COLOR TO GUN COLOR
            Renderer bulletRend = bullet1.GetComponent<Renderer>();
            bulletRend.material.color = newColor;
        }
    }

}




