using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurCollision : MonoBehaviour
{
    private Collider minCollider;

    // Use this for initialization
    void Start()
    {
        minCollider = GetComponent<Collider>();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Feather")
        {
            Physics.IgnoreCollision(col.gameObject.GetComponent<Collider>(), minCollider);
        }

        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
