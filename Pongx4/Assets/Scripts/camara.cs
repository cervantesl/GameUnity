using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour {

	public float velocidadVertical;
	public float velocidadhorizontal;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (0, velocidadVertical, 0);
		transform.Translate (velocidadhorizontal, 0, 0);

	}
}
