using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PictureTurn : MonoBehaviour {

    public float speed = 2.0f;
    
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.R))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        } else if (Input.GetKey(KeyCode.H))
        {
            Application.LoadLevel("BulletHellMinigame");
        }
    }
	
}