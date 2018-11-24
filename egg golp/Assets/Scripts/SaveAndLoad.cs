using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SaveAndLoad : MonoBehaviour {

    private bool alreadyHatched = false;
    private int apparentEggCount = 0;

    void Start () {
        Load();
	}
	
	// Update is called once per frame
	void Update () {
        
        /*if(Input.GetKey(KeyCode.UpArrow))
        {
            IncrementSaveState("eggCount");
        }*/
        
        if (Input.GetKey(KeyCode.N) && Input.GetKey(KeyCode.E) && Input.GetKey(KeyCode.W))
        {
            Application.LoadLevel("NewGame");
        }
        if (Input.GetKey(KeyCode.B) && Input.GetKey(KeyCode.O) && Input.GetKey(KeyCode.P))
        {
            Debug.Log("owo");
            for (int i = 0; i < 10; i++)
            {
                VisibleEggIncrease();
            }
        }

        if(apparentEggCount < PlayerPrefs.GetInt("eggCount"))
        {
            ResyncVisuals();
            apparentEggCount++;
        }


        

    }
	
    public void Load()
    {
        /* I think this needs its own program.   But I'm pretty sure I still need interactives list because that isn't a player pref.
		if (startNew)
        {
            PlayerPrefs.DeleteAll();
            */
			List<string> saveVariables = new List<string>();
            //add ALL variables' names. Must match with actual name.
			//MAKE SURE THE LIST HERE MATCHES THE LIST IN BeginGame.cs
			//A child of an object must precede its parent
            saveVariables.Add("eggCount");

        //end adding titles
        /*
        foreach (string s in interactives)
        {
            PlayerPrefs.SetInt(s + "Active", 1);
        }


    }
    */

        if (PlayerPrefs.GetInt("eggCount") >= 200)
        {
            GameObject itemToLoad = GameObject.Find("EggCharacter");
            itemToLoad.SetActive(false);
            alreadyHatched = true;
        }
        for (int i = 0; i < PlayerPrefs.GetInt("eggCount"); i++)
        {
            if (PlayerPrefs.GetInt("eggCount") >= 200) //Once Shib has hatched, the increase in size needs to be a little more noticable.
            {
                transform.localScale += new Vector3(0.085f, 0.085f, 0.085f);
            } else
            {
                transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
            }
        }
        Debug.Log(PlayerPrefs.GetInt("eggCount"));
        apparentEggCount = PlayerPrefs.GetInt("eggCount");

        /*
        
        //Tell each of the objects to GameObject.SetActive
		foreach (string s in interactives)
        {
			GameObject currentLoad = GameObject.Find(s);
            if (PlayerPrefs.GetInt(s + "Active") == 1) {
				currentLoad.SetActive(true);
				Debug.Log(s+" has been set to active.");
			} else if (PlayerPrefs.GetInt(s + "Active") == 0){
				currentLoad.SetActive(false);
				Debug.Log(s+" has been set to inactive.");
			} else {
				Debug.Log("Error, load value not 1 (true) or 0 (false).");
			}	
        }
        */

        //I think I have to comment out this line and put it and the whole name-game-so-declare-this-list-of-player-prefs thing in their own script to put in a menu.
        // Application.LoadLevel(firstLevel);
    }


    public void UpdateSaveState(string whatToUpdate, int newValue)
	{
		//Gets a name for what to update, and updates it to the new value passed in.
		PlayerPrefs.SetInt(whatToUpdate, newValue);
		
	}

    public void IncrementSaveState(string whatToUpdate)
    {
        //Gets a name for what to update, and updates it to 1 higher.
        int currentValue = PlayerPrefs.GetInt(whatToUpdate);
        PlayerPrefs.SetInt(whatToUpdate, currentValue + 1);
        apparentEggCount++;
    }

    public int ReturnSaveState(string whatToSend)
    {
        return PlayerPrefs.GetInt(whatToSend);
    }
    
    public void VisibleEggIncrease() //Use this to add an egg while in this scene.
    {
        //Do all the stuff that normally happens when you tally up eggs in the start of the program.
        IncrementSaveState("eggCount");
        if (PlayerPrefs.GetInt("eggCount") >= 200) //Once Shib has hatched, the increase in size needs to be a little more noticable.
        {
            transform.localScale += new Vector3(0.085f, 0.085f, 0.085f);
        }
        else
        {
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
        /*Vector3 newScale = transform.localScale;
        newScale *= 1.023f;
        transform.localScale = newScale;*/
        if (alreadyHatched == false)
        {
            if (PlayerPrefs.GetInt("eggCount") >= 200)
            {
                GameObject itemToLoad = GameObject.Find("EggCharacter");
                itemToLoad.SetActive(false);
                alreadyHatched = true;
            }
        }

        Debug.Log(PlayerPrefs.GetInt("eggCount"));
    }

    public void ResyncVisuals() //Use this when an egg is externally added.
    {
        //Remove the part that actually increases eggCount.
        if (PlayerPrefs.GetInt("eggCount") >= 200) //Once Shib has hatched, the increase in size needs to be a little more noticable.
        {
            transform.localScale += new Vector3(0.085f, 0.085f, 0.085f);
        }
        else
        {
            transform.localScale += new Vector3(0.05f, 0.05f, 0.05f);
        }
        /*Vector3 newScale = transform.localScale;
        newScale *= 1.023f;
        transform.localScale = newScale;*/
        if (alreadyHatched == false)
        {
            if (PlayerPrefs.GetInt("eggCount") >= 200)
            {
                GameObject itemToLoad = GameObject.Find("EggCharacter");
                itemToLoad.SetActive(false);
                alreadyHatched = true;
            }
        }

        Debug.Log(PlayerPrefs.GetInt("eggCount"));
    }



}