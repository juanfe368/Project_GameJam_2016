using UnityEngine;
using System.Collections;

public class OffsetScroller : MonoBehaviour {
    private float scrollSpeed = 0;
	private bool walking = false;
    private Vector2 savedOffset;
	void Start () {
        savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");
    }
	
    public void setScrollSpeed(float inpSpeed){
        scrollSpeed = inpSpeed;
    }
	public void setWalkingStatus(bool inpWalking){
		walking = inpWalking;
	}
	void Update () {
        //float x = Mathf.Repeat();
		if (true) {
			Debug.Log (scrollSpeed);
			Vector2 offset = new Vector2 (Time.time * scrollSpeed, 0);
			GetComponent<Renderer> ().sharedMaterial.SetTextureOffset ("_MainTex", offset);
		} else {
			Debug.Log ("El tales");
		}
	}
    void OnDisable(){
        //GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
