using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class DoorEggs : MonoBehaviour {

    Animator animator;

    public AudioSource source;
    public AudioClip pointSound;
    public float pointVolume = 1;

    void Start () {
        source = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

        animator.SetBool("openTheDoor", false);

        if (Input.GetKey(KeyCode.D))
        {
            //Debug.Log("Signal received.");
            animator.SetBool("openTheDoor", true);
            if (PlayerPrefs.GetInt("eggDoorUsed") == 0)
            {
                //Debug.Log("Door reward received");
                PlayerPrefs.SetInt("eggDoorUsed", 1);
                for (int i = 0; i < 12; i++)
                {
                    IncrementSaveState("eggCount");
                }
                source.PlayOneShot(pointSound, pointVolume);
            }
        }
	}
	
    
    public void IncrementSaveState(string whatToUpdate)
    {
        //Gets a name for what to update, and updates it to 1 higher.
        int currentValue = PlayerPrefs.GetInt(whatToUpdate);
        PlayerPrefs.SetInt(whatToUpdate, currentValue + 1);
    }

}