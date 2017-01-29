using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour {


	public float tX= 0;
	public float tY = 0;
	public float tZ = 0;

	public float xs = 0;
	public float ys  = 0;
	public float zs  = 0;

	public float vx  = 0;
	public float vy  = 0;
	public float vz  = 0;

	public float a  = 0.03f;

	public Transform targetTrans;

	private Transform trans;

	public float dd = 0.96f;

	// Use this for initialization
	void Awake () {
		trans = this.gameObject.transform;
		a =  0.03f + Random.value * 0.03f;

	}
	
	// Update is called once per frame
	void Update () {
		trans.position = new Vector3(xs, ys, zs);

	}

	void FixedUpdate(){
		tX = targetTrans.position.x;
		tY = targetTrans.position.y;
		tZ = targetTrans.position.z;

		xs += vx += (tX - xs ) * a;
		ys += vy += (tY - ys ) * a;
		zs += vz += (tZ - zs ) * a;
		vx *= dd;
		vy *= dd;
		vz *= dd;

	}
}
