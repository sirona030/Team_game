using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	public float speed; // 移動スピード

	void Update () {
		transform.Translate (0, 0, 1);
		if (transform.position.z > 50) {
			Destroy (gameObject);
		}
	}

	void FixedUpdate () {
		//GetComponent<Rigidbody>().velocity = transform.forward * speed;
		//FindObjectOfType<Score>().Save();
	}
}
