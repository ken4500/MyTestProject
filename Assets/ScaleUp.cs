using UnityEngine;
using System.Collections;


public class ScaleUp : MonoBehaviour {

	public float scaleRate = 1.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.D)) {
			LevelUp ();
		}
	}

	public void LevelUp() {
		var moveHash = new Hashtable();
        moveHash.Add("x", scaleRate);
        moveHash.Add("y", scaleRate);
        moveHash.Add("z", scaleRate);
        moveHash.Add ("time", 1f);
		moveHash.Add ("easeType", "easeInOutSine");
		iTween.ScaleBy (this.gameObject, moveHash);
	}
}
