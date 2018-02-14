using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyMovement : MonoBehaviour {
    public float speed; 
    private Vector3 direction;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        InvokeRepeating("ChangeDirection", 0, 2); //calls ChangeDirection() every 2 seconds
    }

    void ChangeDirection() {
        int randnum = UnityEngine.Random.Range(0, 4);
        Debug.Log("Randnum: " + randnum);
        if (randnum == 0)
        {
            //direction = transform.right;
            direction = Vector3.back;
        }
        else if (randnum == 1)
        {
            //direction = -transform.right;
            direction = Vector3.forward;
        }
        else if (randnum == 2)
        {
            //direction = transform.forward;
            direction = Vector3.right;
        }
        else {
            //direction = -transform.forward;
            direction = Vector3.left;
        }
        
    }

    private void moveObject(Vector3 direction)
    {
        //rb.velocity += direction * speed * Time.deltaTime;
        transform.position += direction * speed * Time.deltaTime;
    }
    
	// Update is called once per frame
	void Update () {
        moveObject(direction);

    }
}
