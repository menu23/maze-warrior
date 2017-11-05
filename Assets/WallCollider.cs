using UnityEngine;
using System.Collections;

public class WallCollider : MonoBehaviour {

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void OnCollisionEnter (Collision coll) {
		
		//if (coll.collider.tag == "Wall")
		//	rb.isKinematic = true;

		rb.velocity = Vector3.zero;
	}

	/*void OnCollisionExit (Collision coll) {
			rb.isKinematic = false;
	}*/
}
