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
	private bool walking = false;
	float velParal = 0.01f;

    // Use this for initialization
    void Start () {
		backFront.setScrollSpeed (velParal);
		backFront1.setScrollSpeed (velParal);
		backSemiFront.setScrollSpeed (velParal * 0.8f);
		backSemiFront1.setScrollSpeed (velParal * 0.8f);
		backSemiBack.setScrollSpeed (velParal * 0.6f);
		backSemiBack1.setScrollSpeed (velParal * 0.6f);
		backBack.setScrollSpeed (velParal * 0.4f);
		backBack1.setScrollSpeed (velParal * 0.4f);
		backCave.setScrollSpeed (velParal * 0.2f);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("right")){
			walking = true;
        }
        else if (Input.GetKeyDown("left"))
        {
			walking = true;
        }
		if (Input.GetKeyUp ("right") || Input.GetKeyUp ("left")) {
			walking = false;
		}
		if (walking) {
			backFront.setWalkingStatus (true);
			backFront1.setWalkingStatus (true);
			backSemiFront.setWalkingStatus (true);
			backSemiFront1.setWalkingStatus (true);
			backSemiBack.setWalkingStatus (true);
			backSemiBack1.setWalkingStatus (true);
			backBack.setWalkingStatus (true);
			backBack1.setWalkingStatus (true);
			backCave.setWalkingStatus (true);
		} else {
			backFront.setWalkingStatus (false);
			backFront1.setWalkingStatus (false);
			backSemiFront.setWalkingStatus (false);
			backSemiFront1.setWalkingStatus (false);
			backSemiBack.setWalkingStatus (false);
			backSemiBack1.setWalkingStatus (false);
			backBack.setWalkingStatus (false);
			backBack1.setWalkingStatus (false);
			backCave.setWalkingStatus (false);
		}

    }
}