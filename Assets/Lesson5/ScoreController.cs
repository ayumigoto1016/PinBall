using System.Collections;
using UnityEngine.UI;
using UnityEngine;


public class ScoreController : MonoBehaviour {
	
	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {

		score = 0;
		SetScore ();


	}


	void Update (){
		


	}


	void OnCollisionEnter(Collision collision)
    {
		string tag = collision.gameObject.tag;

		if (tag == "SmallStarTag") { 
			score += 3;
		} else if (tag == "LargeStarTag") {
			score += 6;
		} else if (tag == "SmallCloudTag") {
			score += 9;
		} else if (tag == "LargeCloudTag") {
			score += 12;
		}

		SetScore ();


	}

	void SetScore(){
		scoreText.text = string.Format("Score:{0}", score);
	}



}
	