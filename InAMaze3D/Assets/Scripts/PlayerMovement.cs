using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    
    public float speed;

   

    //Private Vars
    private Rigidbody rb;
    private AudioSource footsteps;
   

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        footsteps = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    
	void Update () {
        footsteps.Pause();
        if (Input.GetKey(KeyCode.W)) {
            transform.position += Vector3.forward * speed * Time.deltaTime;
            footsteps.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * speed * Time.deltaTime;
            footsteps.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            footsteps.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            footsteps.Play();
        }

    }
}
