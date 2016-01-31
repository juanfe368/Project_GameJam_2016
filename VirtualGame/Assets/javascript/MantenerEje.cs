using UnityEngine;
using System.Collections;

public class MantenerEje : MonoBehaviour {

	public GameObject player;
	private Transform playerPosition;

	// Use this for initialization
	void Start () {
		playerPosition = player.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay(Collider other) {
		if (other.gameObject.name == "ThirdPersonController") {
			//other.gameObject.transform.position.z = 0;
			player.transform.position = new Vector3(other.gameObject.transform.position.x,other.gameObject.transform.position.y,0);
		}

	}
}
