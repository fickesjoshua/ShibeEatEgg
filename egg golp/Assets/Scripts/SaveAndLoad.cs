using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class SaveAndLoad : MonoBehaviour {

    bool testState = false;

	void Start () {
        Load();
	}
	
	// Update is called once per frame
	void Update () {
        if (testState)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            IncrementSaveState("eggCount");
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

        if (PlayerPrefs.GetInt("eggCount") >= 5)
        {
            testState = true;
        }
        for (int i = 0; i < PlayerPrefs.GetInt("eggCount"); i++)
        {
            transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        }
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
    }

    public int ReturnSaveState(string whatToSend)
    {
        return PlayerPrefs.GetInt(whatToSend);
    }
}