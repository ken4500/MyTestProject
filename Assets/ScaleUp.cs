using UnityEngine;
using System.Collections;


public class ScaleUp : MonoBehaviour {

	public float scaleUpMagnitude;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) {
			var moveHash = new Hashtable();
			moveHash.Add ("y", scaleUpMagnitude);
			moveHash.Add ("time", 1f);
			moveHash.Add ("easeType", "easeInOutSine");
			iTween.MoveBy (this.gameObject, moveHash);
		}
	}
}
