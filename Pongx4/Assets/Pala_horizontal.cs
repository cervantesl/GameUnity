using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pala_horizontal : MonoBehaviour {

	public KeyCode izquierda;
	public KeyCode derecha;

	public float speed;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(izquierda)){
			transform.Translate (-speed, 0, 0);
		}
		if(Input.GetKey(derecha) ){
			transform.Translate (speed, 0, 0);
		}
	}
}
