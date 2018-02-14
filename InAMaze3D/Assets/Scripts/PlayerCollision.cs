using Cradle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour {
    private Rigidbody rb;
    private bool hit;
    private int featherCount;
    private Collider playerCollider;
    private string passageName;
    private List<int> featherList;
    private int randomNum;
    private int selectedPassage;
    private AudioSource footsteps;


    public Text CountText;
    public Canvas TwineTextPlayerCanvas;
    public Story TwineTextPlayerStory;
    

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
        hit = false;
        featherCount = 0;
        playerCollider = GetComponent<Collider>();
        footsteps = GetComponent<AudioSource>();

    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Feather")
        {
            footsteps.Pause();
            Time.timeScale = 0;
            TwineTextPlayerCanvas.enabled = true;
            featherCount = featherCount + 1;
            SetCountText();
            passageName = "Feather " + featherCount;
            //passageName = "Feather 10";
            TwineTextPlayerStory.GoTo(passageName); //serve up a Twine passage
            Destroy(col.gameObject);

        }

        if  (col.gameObject.name == "Minotaur"){
            transform.position = new Vector3(60.1f, 0.9f, -16.9f);
           
        }

        if (col.gameObject.name == "Collider") //Safe Zone
        {
            Physics.IgnoreCollision(col.gameObject.GetComponent<Collider>(), playerCollider);
           
        }
    }



    void SetCountText()
    {
        CountText.text = "Feathers: " + featherCount + " / 10"; 
    }

    // Update is called once per frame
    void Update () {
        
    }
}
