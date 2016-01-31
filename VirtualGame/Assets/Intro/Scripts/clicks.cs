using UnityEngine;
using System.Collections;

public class clicks : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void clickJugar()
    {
        Application.LoadLevel("personajeEscene");
    }
    public void clickAbout()
    {
        Debug.Log("Página en construcción!!");
    }
    public void clickInstrucciones()
    {
        Debug.Log("Página en construcción");
    }
}
