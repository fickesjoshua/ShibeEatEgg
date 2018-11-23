using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BeginGame : MonoBehaviour {
    public string firstLevel = "Test Scene";
    
	
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
            


            PlayerPrefs.SetInt("eggCount", 0);
            

        }
        Application.LoadLevel(firstLevel+"");
    }
	
}