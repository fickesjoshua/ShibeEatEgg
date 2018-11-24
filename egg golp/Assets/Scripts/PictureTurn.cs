using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PictureTurn : MonoBehaviour {

    public float speed = 2.0f;
    private int heckProgress = 0;

	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.T))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * speed);
        }
        else if (heckProgress == 0 && Input.GetKey(KeyCode.H))
        {
            heckProgress = 1;
        }
        else if (heckProgress == 1 && Input.GetKey(KeyCode.E))
        {
            heckProgress = 2;
        }
        else if (heckProgress == 2 && Input.GetKey(KeyCode.C))
        {
            heckProgress = 3;
        }
        else if (heckProgress == 3 && Input.GetKey(KeyCode.K))
        {
            heckProgress = 0;
            Application.LoadLevel("BulletHellMinigame");
        }
        
    }
	
}