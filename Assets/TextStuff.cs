using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextStuff : MonoBehaviour {
    public Text mainText;
    public GameObject trigger;
	// Use this for initialization
	void Start () {
        mainText.text = "Press Space to Start";
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            mainText.text = "And it's off...";
        }
		
	}

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject == trigger)
        mainText.text = "Strike!!";
    }
}
