using UnityEngine;
using System.Collections;

public class CamaraMain : MonoBehaviour {

	public Transform player;
	public Vector3 offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null) {
			transform.position = new Vector3 (player.position.x + offset.x, offset.y, offset.z);
		}
		else {
			GameObject clone = GameObject.FindGameObjectWithTag ("Player");
			transform.position = new Vector3 (clone.transform.position.x + offset.x, clone.transform.position.y, offset.z);
		}
	}
}
