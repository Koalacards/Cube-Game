using UnityEngine;
using System.Collections;

public class OutBoundsSpace : MonoBehaviour {

		public GameObject checkpoint;

		private PlayerControllerSpace player;

	// Use this for initialization
	void Start () {
				player = FindObjectOfType<PlayerControllerSpace> ();

	}

		void OnTriggerEnter2D(Collider2D other)
		{
				if (other.name == "Protagonist") {
						RespawnPlayer ();
				}
		}

		void RespawnPlayer()
		{
				player.gameObject.transform.position = checkpoint.transform.position;
				player.gameObject.transform.rotation = checkpoint.transform.rotation;
		}
}
