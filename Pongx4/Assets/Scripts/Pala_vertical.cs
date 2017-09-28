using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala_vertical : MonoBehaviour {

	public KeyCode arriba;
	public KeyCode abajo;

	public float speed = 0.05f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(arriba)){
			transform.Translate (0, speed, 0);
		}
		if(Input.GetKey(abajo)){
			transform.Translate (0, -speed, 0);
		}
	}
}
