using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BeginGame : MonoBehaviour {
    public string firstLevel = "TestArea";
    
	
    //public int guestsPerArea = 3;
	// Use this for initialization
	void Start () {
        BeginTheGame(true);
	}
	
	// Update is called once per frame
	void Update () {
        
	}
	
    public void BeginTheGame(bool startNew)
    {
        if (startNew)
        {
            PlayerPrefs.DeleteAll();
            
			List<string> saveVariables = new List<string>();

            //add ALL variables' names. Must match with actual name.
            //MAKE SURE THE LIST HERE MATCHES THE LIST IN SaveAndLoad.cs
            //A child of an object must precede its parent
            saveVariables.Add("eggCount");
            //end adding titles

            /*foreach (string s in interactives)
            {
                PlayerPrefs.SetInt(s + "Active", 1);
            }*/


            PlayerPrefs.SetInt("eggCount", 0);
            //Still need to actually say which things are then set as inactive.
            /*PlayerPrefs.SetInt("box red foyer trigger" + "Active", 0);
			PlayerPrefs.SetInt("lock red foyer trigger" + "Active", 0);
			PlayerPrefs.SetInt("foyer-parlor door trigger" + "Active", 0);
			PlayerPrefs.SetInt("box gray foyer trigger" + "Active", 0);
			PlayerPrefs.SetInt("lock gray foyer trigger" + "Active", 0);
			PlayerPrefs.SetInt("flower stem trigger" + "Active", 0);
			PlayerPrefs.SetInt("stairs-hall door trigger" + "Active", 0);
			PlayerPrefs.SetInt("key red foyer" + "Active", 0);
			PlayerPrefs.SetInt("key gray foyer" + "Active", 0);
			PlayerPrefs.SetInt("rose foyer vase" + "Active", 0);
			PlayerPrefs.SetInt("riddle foyer" + "Active", 0);
			PlayerPrefs.SetInt("atticstairs-attic door trigger" + "Active", 0);
			PlayerPrefs.SetInt("lid off" + "Active", 0);
			PlayerPrefs.SetInt("lower stair sconce" + "Active", 0);
			
			PlayerPrefs.SetInt("TomatoPlace1" + "Active", 0);
			PlayerPrefs.SetInt("TomatoPlace2" + "Active", 0);
			PlayerPrefs.SetInt("TomatoPlace3" + "Active", 0);
			PlayerPrefs.SetInt("tomato sink 1" + "Active", 0);
			PlayerPrefs.SetInt("tomato sink 2" + "Active", 0);
			PlayerPrefs.SetInt("tomato sink 3" + "Active", 0);
			PlayerPrefs.SetInt("cut slice" + "Active", 0);
			PlayerPrefs.SetInt("insert toast trigger" + "Active", 0);
			PlayerPrefs.SetInt("toast slice down" + "Active", 0);
			PlayerPrefs.SetInt("toaster button" + "Active", 0);
			PlayerPrefs.SetInt("toast slice up" + "Active", 0);
			PlayerPrefs.SetInt("plate 1" + "Active", 0);
			PlayerPrefs.SetInt("plate 2" + "Active", 0);
			PlayerPrefs.SetInt("plate 3" + "Active", 0);
			PlayerPrefs.SetInt("plate 4" + "Active", 0);
			PlayerPrefs.SetInt("plate 5" + "Active", 0);
			PlayerPrefs.SetInt("plate 6" + "Active", 0);
			PlayerPrefs.SetInt("plate 7" + "Active", 0);
			PlayerPrefs.SetInt("plate 8" + "Active", 0);
			PlayerPrefs.SetInt("plate table triggers" + "Active", 0);
			PlayerPrefs.SetInt("freezer door trigger" + "Active", 0);
			PlayerPrefs.SetInt("lock green kitchen trigger" + "Active", 0);
			PlayerPrefs.SetInt("Cucumber on Board" + "Active", 0);
			PlayerPrefs.SetInt("Cucumber on Board trigger" + "Active", 0);
			PlayerPrefs.SetInt("Cucumber on Board Sliced" + "Active", 0);
			PlayerPrefs.SetInt("Cucumber Slicing Triggers" + "Active", 0);
			*/

        }
        Application.LoadLevel(firstLevel+"");
    }
	
}