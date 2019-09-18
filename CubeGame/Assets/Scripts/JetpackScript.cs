using UnityEngine;
using System.Collections;

public class JetpackScript : MonoBehaviour {
		private PlayerControllerSpace player;
		public float Jetpackoffset = 0.1f;
		public bool intouch;
		public float Jetpacktime = 3f;
		float ResetTime = 6f;

		Animator anim;
	void Start () {
				player = FindObjectOfType<PlayerControllerSpace> ();
				anim = this.gameObject.GetComponent<Animator> ();
				intouch = false;
	}
	
	
	void Update () {
				if (intouch) {
						this.gameObject.transform.position = new Vector2 (player.gameObject.transform.position.x, player.gameObject.transform.position.y);
						Invoke ("ExitJetpack", Jetpacktime);
				}
	}



		void OnTriggerEnter2D(Collider2D other)
		{
				if (other.name == "Protagonist") {
						intouch = true;
						anim.SetBool ("OnContact", true);
						Jetpackstuff ();
				}

		}

		void OnTriggerExit2D()
		{
				intouch = false;
				anim.SetBool("OnContact",false);
		}


		void ExitJetpack()
		{
				this.gameObject.SetActive (false);
				Invoke ("ReappearJetpack", ResetTime);
		}

		void Jetpackstuff()
		{
				
				player.JetpackBoost ();

				Invoke ("ExitJetpack", Jetpacktime);
		}

		void ReappearJetpack()
		{
				this.gameObject.SetActive (true);
		}
}
