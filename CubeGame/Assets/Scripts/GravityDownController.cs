using UnityEngine;
using System.Collections;

public class GravityDownController : MonoBehaviour {

		private PlayerControllerSpace player;

	// Use this for initialization
	void Start () {
				player = FindObjectOfType<PlayerControllerSpace> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

		void OnTriggerEnter2D(Collider2D other)
		{
				if (other.name == "Protagonist") {
						player.Gravitize ();
						this.gameObject.SetActive (false);
				}
		}
}
