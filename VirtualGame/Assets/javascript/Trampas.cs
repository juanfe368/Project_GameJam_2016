using UnityEngine;
using System.Collections;

public class Trampas : MonoBehaviour {

	private bool activarConCamara = false;
	public float cantidadSubir = 10f;
	private float posInicial;
	private float posFinal;

	// Use this for initialization
	void Start () {
		posInicial = transform.position.y;
		posFinal = transform.position.y + cantidadSubir;
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y>=posFinal){
			activarConCamara = false;
		}
		if(activarConCamara){
			transform.Translate (0, (cantidadSubir * Time.deltaTime), 0);
			Debug.Log (transform.position.y);
		}
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.name == "ActivadorFrontal") {
			activarConCamara = true;
			//transform.Translate(Vector3.Lerp(transform.position, new Vector3(0,(transform.position.y + cantidadSubir),0),2f));
		}
		else if(other.gameObject.name == "ThirdPersonController"){
			
		}
	}

	/*void OnBecameVisible () {
		Debug.Log("Entro al become");
	}*/
}
