using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerControllerSpace : MonoBehaviour {

		private Rigidbody2D rb2d;

		public float speed = 6f;

		public Vector2 AirCurrentUp;

		public bool OnTopAir;

		private Level3ManagerScript lvl3;


		public Text triggerText;

		public Vector2 TrampVelocity;

		public float TextTime = 5f;

		private float Gravitime = 3f;

		private GravityDownController gdown;

		public Vector2 JetPackForce;

		public Vector2 SmallTrampVelocity;

	void Start () {
				rb2d = GetComponent<Rigidbody2D> ();
				triggerText.text = "";
				gdown = FindObjectOfType<GravityDownController> ();
	}
	

		void FixedUpdate() {
			float moveHorizontal = Input.GetAxis ("Horizontal");
			Vector2 move = new Vector2 (moveHorizontal, 0);
			rb2d.AddForce (move * speed);
			
		}

	void Update () {
		if (OnTopAir == true) 
		{
				Boost();
		}
	}




		void OnTriggerEnter2D(Collider2D other)
		{
				if(other.name == "AirCurrent") 
				{
						OnTopAir = true;
				}

				if (other.name == "HintTrigger") {
						triggerText.text = "Hint: To Go Up You \nMust First Go Down.";
								Invoke("ReHideText", TextTime);

				}

		}

		void OnTriggerExit2D()
		{
				OnTopAir = false;
		}



		public void Boost()
		{
				rb2d.velocity = AirCurrentUp;
		}

		public void JumpTramp()
		{
				rb2d.velocity = TrampVelocity;
		}

		public void ReHideText()
		{
				triggerText.text = "";
		}

		public void Gravitize()
		{
				rb2d.gravityScale = 1f;
				Invoke ("BackToSpace", Gravitime);
						}

		public void BackToSpace()
		{
				rb2d.gravityScale = 0.3f;
				gdown.gameObject.SetActive (true);
		}

		public void JetpackBoost()
		{
				rb2d.velocity = JetPackForce;
		}

		public void JumpTrampSmall()
		{
				rb2d.velocity = SmallTrampVelocity;
		}
}
