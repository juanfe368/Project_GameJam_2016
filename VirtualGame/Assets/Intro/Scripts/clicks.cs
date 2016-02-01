using UnityEngine;
using System.Collections;
using System;

public class clicks : MonoBehaviour {

    private static string curScene = "";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public static void setActualScene(string inpCurScene)
    {
        curScene = inpCurScene;
    }
    public void clickJugar()
    {
        Application.LoadLevel("Start");
    }
    public void clickAbout()
    {
        Debug.Log("Página en construcción!!");
    }
    public void clickInstrucciones()
    {
        Debug.Log("Página en construcción");
    }
    public void clickSalir()
    {
        Application.LoadLevel("Intro");
    }
    public void clickVolver()
    {
        try {
            if (curScene != "") {
                Application.LoadLevel(curScene);
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

    }
}
