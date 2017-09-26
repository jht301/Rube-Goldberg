using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggersCamera : MonoBehaviour {
    public Camera cameraFrom;
    public Camera cameraTo;
    public GameObject trigObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other) {
        if(other.gameObject == trigObj) {
            cameraFrom.enabled = false;
            cameraTo.enabled = true;
        }
    }
}
