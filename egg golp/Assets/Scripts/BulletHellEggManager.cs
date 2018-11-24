using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class BulletHellEggManager : MonoBehaviour {

    public float speed = 2.0f;
    
	void Start () {
        IncrementSaveState("eggCount");
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        } else if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
	}
	
    
    public void IncrementSaveState(string whatToUpdate)
    {
        //Gets a name for what to update, and updates it to 1 higher.
        int currentValue = PlayerPrefs.GetInt(whatToUpdate);
        PlayerPrefs.SetInt(whatToUpdate, currentValue + 1);
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "hazard")
        {
            Application.LoadLevel("Test Scene");
        }

        if (collision.gameObject.tag == "point")  //I'm also adding the win condition check here since it's so similar to a death check.
        {
            IncrementSaveState("eggCount");
            IncrementSaveState("eggCount");
            IncrementSaveState("eggCount");
            Destroy(collision.gameObject);
        }
    }

}