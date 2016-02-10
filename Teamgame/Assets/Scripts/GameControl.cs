using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameControl : MonoBehaviour {
	public int rotateCount = 0;
	public float angle = 1f;
	public int Obj_num = 5;
	public int pre_count;
	public GameObject[] obj = new GameObject[5];
	private List<GameObject> objFront;
	private List<GameObject> objLeft;
	private List<GameObject> objRight;
	private List<GameObject> objBack;

	void Start () {
		objFront = new List<GameObject> ();
		objLeft = new List<GameObject> ();
		objRight = new List<GameObject> ();
		objBack = new List<GameObject> ();
		objFront.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(0, 1.5f, 12), transform.rotation) as GameObject);
		objFront.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(4, 1.5f, 12), transform.rotation) as GameObject);
		objFront.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(-4, 1.5f, 12), transform.rotation) as GameObject);
		for (int i = 0; i < 3; i++) {
			objFront[i].transform.parent = this.gameObject.transform;
		}
		objLeft.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(12, 1.5f, 0), transform.rotation) as GameObject);
		objLeft.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(12, 1.5f, 4), transform.rotation) as GameObject);
		objLeft.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(12, 1.5f, -4), transform.rotation) as GameObject);
		for (int i = 0; i < 3; i++) {
			objLeft[i].transform.parent = this.gameObject.transform;
		}
		objRight.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(-12, 1.5f, 0), transform.rotation) as GameObject);
		objRight.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(-12, 1.5f, 4), transform.rotation) as GameObject);
		objRight.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(-12, 1.5f, -4), transform.rotation) as GameObject);
		for (int i = 0; i < 3; i++) {
			objRight[i].transform.parent = this.gameObject.transform;
		}
		objBack.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(0, 1.5f, -12), transform.rotation) as GameObject);
		objBack.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(4, 1.5f, -12), transform.rotation) as GameObject);
		objBack.Add(Instantiate (obj[Random.Range (0, Obj_num)], new Vector3(-4, 1.5f, -12), transform.rotation) as GameObject);
		for (int i = 0; i < 3; i++) {
			objBack[i].transform.parent = this.gameObject.transform;
		}
	}

	void Update () {
		int childCount = this.gameObject.transform.childCount;
		Debug.Log (childCount);
		if (rotateCount > 0) {
			//GetComponent<Rigidbody> ().MoveRotation (Quaternion.AngleAxis (angle, Vector3.up));
			transform.Rotate(new Vector3(0f,1f,0f));
			rotateCount--;
		}
		if (childCount == 4) {
			
		}
		else if (childCount != pre_count) {
			pre_count = childCount;
			if (childCount%3 == 1) {
				rotateCount = 90;
			}
		}
	}
}
