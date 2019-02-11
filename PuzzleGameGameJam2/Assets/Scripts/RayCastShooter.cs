using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastShooter : MonoBehaviour
{

    
    public float fireRate = 0.25f;          //Sets the fire rate of the gun
    public Transform gunEnd;        //Marks the postion at which out laser line begins
    public float weaponRange = 50f;
    public float hitForce = 100f;

    private Camera fpsCam;          //Will refer to out parent camera object
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);    //How long the laser is visible once player has fired
    private AudioSource gunAudio;   //Gun Soun when firing ammo

    private float nextFire;         //Determines when the player can fire again
    public Transform bulletPrefab;
   
    void Start()
    {
        gunAudio = GetComponent<AudioSource>();     //Storing reference to our AudioSource
        fpsCam = GetComponentInParent<Camera>();    //Refers to the parent Camera Object
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            Transform bullet1 = Instantiate(bulletPrefab, gunEnd.transform.position, Quaternion.identity);
            bullet1.forward = gunEnd.transform.forward;
            //bullet1.forward = Camera.main.transform.forward;
            StartCoroutine(ShotEffect());  //Starting the Coroutine of shot effect
        }

    }  
    private IEnumerator ShotEffect()

    {
        gunAudio.Play();    //Plays the AudioClip assigned to the Audio
        
        yield return shotDuration;

    }
}
