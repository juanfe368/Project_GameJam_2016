using UnityEngine;
using System.Collections;

public class CamareMain : MonoBehaviour {

	public GameObject character;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		FollowCharacter ();
	}

	void FollowCharacter(){
		//transform.Translate ((character.transform.position.x)*Time.deltaTime,0,-10);
	}
}
