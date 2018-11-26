using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class TreeEggControl : MonoBehaviour {

    Animator animator; //Get ready to get the animator connected to the tree egg.

    public AudioSource source;
    public AudioClip pointSound;
    public float pointVolume = 1;


    void Start () {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>(); //Get the animator connected to the tree egg.
    }
	
	// Update is called once per frame
	void Update () {


        animator.SetBool("EggDrop", false);
        animator.SetBool("EggCaught", false);


        if (Input.GetKey(KeyCode.Space)) //When the player presses the space bar...
        {
            Debug.Log("Roger that.");
            animator.SetBool("EggDrop", true); //The egg falls!
        }
        if (Input.GetKey(KeyCode.Y))
        {
            Debug.Log("Return Egg.");
            DoTheThing();
        }


    }

    void DoTheThing()
    {
        Debug.Log("Debug the thing.");
        source.PlayOneShot(pointSound, pointVolume);
        animator.SetBool("EggCaught", true); //The egg falls!
    }

    void OnTriggerEnter(Collider collision)
    {
        Debug.Log("poke!");
        if (collision.gameObject.tag == "player") //If the tree egg touches the main character egg/shiba...
        {
            Debug.Log("Egg poke player");
            DoTheThing();
            int currentValue = PlayerPrefs.GetInt("eggCount");
            PlayerPrefs.SetInt("eggCount", currentValue + 1);
        }

        
    }
}