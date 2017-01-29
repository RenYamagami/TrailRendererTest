using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pointing : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


		this.transform.position = new Vector3 (100 * Mathf.Sin (10f*Time.time),500*Mathf.Sin(Time.time), 100 * Mathf.Cos (10f*Time.time));
	}
}
