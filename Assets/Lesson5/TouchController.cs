using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

	private HingeJoint myHingeJoint;
	private float defaultAngle = 20;
	private float flickAngle = -20;

	// Use this for initialization
	void Start () {
		this.myHingeJoint = GetComponent<HingeJoint> ();
		SetAngle (this.defaultAngle);

	}

	// Update is called once per frame
	void Update () {



		if(Input.touchCount > 0){



			for (int i = 0; i < Input.touchCount; i++) {
				Touch touch = Input.GetTouch (i);
				Touch[] myTouches = Input.touches;
		
				
			if (touch.phase == TouchPhase.Began && touch.position.x > Screen.width * 0.5f && tag == "RightFripperTag") {
				SetAngle (this.flickAngle);
			}
			if (touch.phase == TouchPhase.Began && touch.position.x < Screen.width * 0.5f && tag == "LeftFripperTag") {
				SetAngle (this.flickAngle);
				}

			if (touch.phase == TouchPhase.Ended) {
				SetAngle (this.defaultAngle);
			}




	}
	}
	}


	public void SetAngle (float angle){
		JointSpring jointSpr = this.myHingeJoint.spring;
		jointSpr.targetPosition = angle;
		this.myHingeJoint.spring = jointSpr;

	}
}