using UnityEngine;
using System.Collections;

public class Parallax : MonoBehaviour {
    
    public OffsetScroller backFront;
    public OffsetScroller backSemiFront;
    public OffsetScroller backSemiBack;
    public OffsetScroller backBack;
    public OffsetScroller backFront1;
    public OffsetScroller backSemiFront1;
    public OffsetScroller backSemiBack1;
    public OffsetScroller backBack1;
    public OffsetScroller backCave;

    // Use this for initialization
    void Start () {
        	
	}
	
	// Update is called once per frame
	void Update ()
    {
        float velParal = 0.01f;
        if (Input.GetKeyDown("right")){
            backFront.setScrollSpeed(velParal);
            backFront1.setScrollSpeed(velParal);
            backSemiFront.setScrollSpeed(velParal * 0.8f);
            backSemiFront1.setScrollSpeed(velParal * 0.8f);
            backSemiBack.setScrollSpeed(velParal * 0.6f);
            backSemiBack1.setScrollSpeed(velParal * 0.6f);
            backBack.setScrollSpeed(velParal * 0.4f);
            backBack1.setScrollSpeed(velParal * 0.4f);
            backCave.setScrollSpeed(velParal * 0.2f);
        }
        else if (Input.GetKeyDown("left"))
        {
            velParal = -velParal;
            backFront.setScrollSpeed(velParal);
            backFront1.setScrollSpeed(velParal);
            backSemiFront.setScrollSpeed(velParal * 0.8f);
            backSemiFront1.setScrollSpeed(velParal * 0.8f);
            backSemiBack.setScrollSpeed(velParal * 0.6f);
            backSemiBack1.setScrollSpeed(velParal * 0.6f);
            backBack.setScrollSpeed(velParal * 0.4f);
            backBack1.setScrollSpeed(velParal * 0.4f);
            backCave.setScrollSpeed(velParal * 0.2f);
        }
        else
        {
            velParal = 0;
            backFront.setScrollSpeed(velParal);
            backFront1.setScrollSpeed(velParal);
            backSemiFront.setScrollSpeed(velParal * 0.8f);
            backSemiFront1.setScrollSpeed(velParal * 0.8f);
            backSemiBack.setScrollSpeed(velParal * 0.6f);
            backSemiBack1.setScrollSpeed(velParal * 0.6f);
            backBack.setScrollSpeed(velParal * 0.4f);
            backBack1.setScrollSpeed(velParal * 0.4f);
            backCave.setScrollSpeed(velParal * 0.2f);
        }


    }
}
