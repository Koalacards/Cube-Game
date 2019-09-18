using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MidCheckScript : MonoBehaviour {

		private  Checkpoint2 cp;

		public Text midtxt;

		private OutBoundsSpace obs;

		private float waittime = 4f;

	// Use this for initialization
	void Start () {
				midtxt.text = "";
				obs = FindObjectOfType<OutBoundsSpace> ();
				cp = FindObjectOfType<Checkpoint2> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnTriggerEnter2D(Collider2D other)
		{
				if (other.name == "Protagonist") {
						midtxt.text = "Checkpoint!";
								Invoke("DieText", waittime);
						obs.checkpoint = cp.gameObject;
				}

		}
	

		public void DieText()
		{
				midtxt.text = "";
		}
}
