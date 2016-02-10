using UnityEngine;
using System.Collections;

public class Obj : MonoBehaviour {
	/*private GameControl m_owner;
	[SerializeField]
	private GameObject m_ownerObj;

	void Awake(){
		m_owner = m_ownerObj.GetComponent<GameControl> ();
	}*/
	void Update () {
		if (transform.position.y < -5) {
			//m_owner.count--;
			Destroy (gameObject);
		}
	}
}
