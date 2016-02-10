using UnityEngine;
using System.Collections;

public class Script : MonoBehaviour {
	float angle = 0.0f;
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		angle += 2f;
		GetComponent<Rigidbody> ().MoveRotation (Quaternion.AngleAxis (angle, Vector3.up));
	}
}
