using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {

	public GameObject puntoInicial;
	public GameObject player;
    public string nombreEscena = "PiesEscena";
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
            if (puntoInicial != null && player != null)
            {
                Instantiate(player, puntoInicial.transform.position, Quaternion.identity);
                Destroy(other.gameObject);
            }
            bool reiniciarEscena = true;
            if (reiniciarEscena)
            {
                //string nombreEscena = "PiesEscena";
                //Debug.Log("CESAR: ENTRO AL LOAD DE BACKGROUND");
                Application.LoadLevel(nombreEscena);
            }
		}
	}
}
