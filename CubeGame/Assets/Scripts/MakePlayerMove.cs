using UnityEngine;
using System.Collections;

public class MakePlayerMove : MonoBehaviour {

		private LevelIntro lvlintr;

	// Use this for initialization
	void Start () {
				lvlintr = FindObjectOfType<LevelIntro> ();
				lvlintr.CanMove = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
