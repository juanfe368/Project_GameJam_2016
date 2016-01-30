using UnityEngine;
using System.Collections;

public class OffsetScroller : MonoBehaviour {
    public float scrollSpeed;
    private Vector2 savedOffset;
	void Start () {
        savedOffset = GetComponent<Renderer>().sharedMaterial.GetTextureOffset("_MainTex");

    }
	
	void Update () {
        //float x = Mathf.Repeat();
        Vector2 offset = new Vector2(Time.time * scrollSpeed, 0);
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", offset);
	}
    void OnDisable(){
        GetComponent<Renderer>().sharedMaterial.SetTextureOffset("_MainTex", savedOffset);
    }
}
