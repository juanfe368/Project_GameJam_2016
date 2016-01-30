using UnityEngine;
using System.Collections;

public class Esfera : MonoBehaviour {

    public float velocity = 10f;
    private int direcMovimiento;
	private bool jump;
	public float forceJump = 20f;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		direcMovimiento = 1;
		jump = false;
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate(){
		MoveEsfera();
	}

	// Update is called once per frame
	void Update () {
		ValidarTeclas ();
		JumpKey ();
	}

	void ValidarTeclas(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			Debug.Log ("Derecha: "+direcMovimiento);
			direcMovimiento = 1;
		} 
		else if (Input.GetKey (KeyCode.LeftArrow)) {
			Debug.Log ("Izquierda: "+direcMovimiento);
			direcMovimiento = -1;
		}
		else {
			direcMovimiento = 0;
		}
		MoveEsfera ();
	}
    
    void MoveEsfera(){
		
		transform.Translate((velocity*Time.deltaTime)*direcMovimiento,0,0);
    }

	void JumpKey(){
		if(Input.GetButton("Jump")){
			Debug.Log ("Oprimio el salto");
			rb.AddForce(Vector3.up*forceJump);
		}
	}
}
