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
    private LineRenderer laserLine; //Renders a free floating line in space
    private float nextFire;         //Determines when the player can fire again

   
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();   //Storing reference to our LineRenderer
        gunAudio = GetComponent<AudioSource>();     //Storing reference to our AudioSource
        fpsCam = GetComponentInParent<Camera>();    //Refers to the parent Camera Object
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
        }

        StartCoroutine(ShotEffect());   //Starting the Coroutine of shot effect

        //Setting the origin of our ray
        //0.5 on X and Y sets specifies the point in center of player view
        Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(.5f, .5f, 0));

        RaycastHit hit;     //Stores the information of whateve we hit with our Raycast
        laserLine.SetPosition(0, gunEnd.position);  //Sets the start and enf positions of out laser line
                                                    //'gunEnd' = Empty GameObject atrached

        //Casting the ray
        //Begin origin point/setup of Raycast
        if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
        {
            laserLine.SetPosition(1, hit.point);    //Sets endpoint to the hit object
        }
        else
        {
            laserLine.SetPosition(1, fpsCam.transform.forward * weaponRange);   //Sets endpoint to weaponRange
        }


    }  
    private IEnumerator ShotEffect()

    {
        gunAudio.Play();    //Plays the AudioClip assigned to hunAudio
        laserLine.enabled = true;  //Makes the rendered object enabled

        //
        yield return shotDuration;

        laserLine.enabled = false;
    }
}
