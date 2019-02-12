using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{

    public float speed = 3f;
    public float duration = 3f;
    private float startTime;
    private Color color = Color.white;

    //public GameObject Gun;

    Renderer rend;

    Vector3 moveForward = new Vector3(0.0f, 0.0f, 1.0f);

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        //Get the renderer of the object so we can access the color
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(transform.forward * speed * Time.deltaTime);

        // MY CHEAT CODE FOR TESTING
        transform.Translate(moveForward * speed * Time.deltaTime);

        if ((Time.time - startTime) >= duration)
        {
            Destroy(gameObject);
        }

        //if(Input.GetKeyDown(KeyCode.H)) {
        //    rend.material.color = Color.red;
        //}
        //if (Input.GetKeyDown(KeyCode.J))
        //{
        //    rend.material.color = Color.blue;
        //}
        //if (Input.GetKeyDown(KeyCode.K))
        //{
        //    rend.material.color = Color.yellow;
        //}
        //if (Input.GetKeyDown(KeyCode.L))
        //{
        //    rend.material.color = Color.white;
        //}
    }
}
