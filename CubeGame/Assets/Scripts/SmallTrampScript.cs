using UnityEngine;
using System.Collections;

public class SmallTrampScript : MonoBehaviour {

		public bool onTop;

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

				onTop = true;

		}


		void OnTriggerExit2D()
		{
				onTop = false;
		}


		void OnCollisionStay2D(Collision2D other)
		{
				if (onTop = true) {
						player.JumpTrampSmall ();
				}
		}
}
