using UnityEngine;
using System.Collections;

public class CambioEscenario : MonoBehaviour {

	public GameObject puntoInicial;
	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			Instantiate (player, puntoInicial.transform.position, Quaternion.identity);
			Destroy (other.gameObject);
		}
	}
}
