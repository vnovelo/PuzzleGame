using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGun : MonoBehaviour
{
    public Transform bulletPrefab;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Transform bullet1 = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet1.forward = this.transform.forward;
            //bullet1.forward = Camera.main.transform.forward;

            
        }
    }

}




