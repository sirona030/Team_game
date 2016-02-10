using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public GameObject hunya,don,karan,pon,baribari;
	[SerializeField]
	Transform m_camTrasn;
	public string label1,label2,label3,label4,label5;//new
	int gion;

	void Start () {
		
	}

	//new
	void OnGUI(){
		
		if (GUI.Button (new Rect (65, 15, 50, 25), label1)) {
			//Debug.Log("hunya");
			gion = 1;
		Pushed (gion);
		}
		if (GUI.Button (new Rect (120, 15, 50, 25), label2)) {
			gion = 2;
		Pushed (gion);
		}
		if (GUI.Button (new Rect (175, 15, 50, 25), label3)) {
			gion = 3;
		Pushed (gion);
		}
		if (GUI.Button (new Rect (230, 15, 50, 25), label4)) {
			gion = 4;
		Pushed (gion);
		}
		if (GUI.Button (new Rect (285, 15, 60, 25), label5)) {
			gion = 5;
		Pushed (gion);
		}
		
	}

	void Update () {
		//if (Input.GetButtonDown("Fire1")) {
		//	Instantiate ( bullet, transform.position, transform.rotation);
		//}

		//new


	}

	private void Pushed(int localgion){
			switch(localgion){
			case 1:
				//Debug.Log("hunya");
					Instantiate ( hunya, transform.position, transform.rotation);
				break;
			case 2:
				//Debug.Log("don");
					Instantiate ( don, transform.position, transform.rotation);
				break;
			case 3:
				//Debug.Log("karan");
					Instantiate ( karan, transform.position, transform.rotation);
				break;
			case 4:
				//Debug.Log("pon");
					Instantiate ( pon, transform.position, transform.rotation);
				break;
			case 5:
				//Debug.Log("baribari");
					Instantiate ( baribari, transform.position, transform.rotation);
				break;
			default:
				//Debug.Log("Default case");
				break;
			}
	}

}
