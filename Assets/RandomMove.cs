using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour {

	private GameObject moveObject;

	// Use this for initialization
	void Start () {

		moveObject = this.gameObject;

		StartrandomMov ();

	}

	private float timeleft;


	private void Update(){

		timeleft -= Time.deltaTime;

			if (timeleft <= 0.0) {
				timeleft = 0.5f;
			RandomPositionTween ();

				//ここに処理
			}
		

	}




	private void StartrandomMov(){
		RandomPositionTween ();
	}

	private void RandomPositionTween(){

		var easeType = iTween.EaseType.easeInOutSine;
		var toVec = new Vector3 (Random.Range (-50, 50), Random.Range (-50, 50), Random.Range (-50, 50));


		var moveHash = new Hashtable();
		moveHash.Add ("position", toVec);
		moveHash.Add ("time",0.1);
		moveHash.Add ("easetype",easeType);
		moveHash.Add ("oncompletetarget",this.gameObject);
		moveHash.Add ("oncomplete","_postionComplete");
		iTween.MoveTo (this.gameObject, moveHash);


	}

	private void PositionComplete(){

		RandomPositionTween();

	}

	// Update is called once per frame

}
