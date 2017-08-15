using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sporner : MonoBehaviour {

    public GameObject spawnObj;
   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("InstantiateMarble")) {
            Debug.Log("Kugel erstellen");
            

            /*var mousePos = Input.mousePosition;
            mousePos.z = 2;       // we want 2m away from the camera position

            var objectPos = Camera.current.ScreenToWorldPoint(mousePos);

            var myObject = Instantiate(spawnObj, objectPos, Quaternion.identity);*/
        }
	}
}
