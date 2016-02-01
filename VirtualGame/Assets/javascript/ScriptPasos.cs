using UnityEngine;
using System.Collections;

public class ScriptPasos : MonoBehaviour {

    public AudioSource audio;
    // Use this for initialization
    void Start () {
        //audio = GetComponent<AudioSource>();
       // audio.volume = 0.0f;
        //audio.Play(44100);
    }
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<AudioSource>() != null) { 
            audio = GetComponent<AudioSource>();
        }

    
        if (audio != null) { 
        audio.volume = 1f;
        }
    }
}
