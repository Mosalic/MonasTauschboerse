using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    float scaleFactor = 1.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //move forward
        if (Input.GetKey(KeyCode.W)) {
            Debug.Log("W");
            transform.Translate(0.05f, 0f, 0f);
        }
        //move backward
        if (Input.GetKey(KeyCode.S)){
            Debug.Log("S");
            transform.Translate(-0.05f, 0f, 0f);
        }
        //move left
        if (Input.GetKey(KeyCode.A)){
            Debug.Log("A");
            transform.Translate(0f, 0f, 0.05f);
        }
        //move right
        if (Input.GetKey(KeyCode.D)) {
            Debug.Log("D");
            transform.Translate(0f, 0f, -0.05f);
        }
        //rotate Y-Achse, left
        if (Input.GetKey(KeyCode.L))
        {
            Debug.Log("L");
            transform.Rotate(0f, 0.5f, 0f);
        }
        //rotate Y-Achse, right
        if (Input.GetKey(KeyCode.R))
        {
            Debug.Log("R");
            transform.Rotate(0f, -0.5f, 0f);
        }
        //scale bigger
        if (Input.GetKey(KeyCode.C))
        {
            scaleFactor = scaleFactor + 0.1f;
            Debug.Log("C");
            transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
        //scale smaller
        if (Input.GetKey(KeyCode.X))
        {

            if (scaleFactor > 1) {
                scaleFactor = scaleFactor - 0.1f;
            }
            Debug.Log("X");
            transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        }
    }
}
