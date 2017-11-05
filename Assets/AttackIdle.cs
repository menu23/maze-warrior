using UnityEngine;
using System.Collections;

public class AttackIdle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
		GameObject.FindWithTag ("Model").GetComponent<Animation> ().Play ();
	}
	
	// Update is called once per frame
	void Update () {

		GameObject.FindWithTag ("Model").GetComponent<Animation> ().Play ();
	
	}
}
