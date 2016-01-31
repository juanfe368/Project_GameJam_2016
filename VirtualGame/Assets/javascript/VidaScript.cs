using UnityEngine;
using System.Collections;

public class VidaScript : MonoBehaviour {

    public float vidaPersonaje = 1f;
	// Use this for initialization
	void Start () {
       // vidaPersonaje = 1f;
    }
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "MortalEnemy")
        {
            vidaPersonaje = 0f;
        }
    }
}
