using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Level3ManagerScript : MonoBehaviour {

		public Text firstText;

		public Text secondText;

		public Text thirdText;

		private float WaitSecondTime = 4f;

		public bool CanMove;

		private PlayerControllerSpace player;

		public Text EndText;

		public GameObject button; 
	void Start () {
				firstText.text = ("Hmm. maybe I could have\n gone back and gotten\n another ice cream instead \nof coming into space.");
				secondText.text = "";
				thirdText.text = "";

				StartCoroutine(BeginningText());

				player = FindObjectOfType<PlayerControllerSpace> ();

				player.speed = 0;

				EndText.text = "";



	}
				

		void ShowText()
		{
				EndText.text = "Level Complete";
		}
	
		IEnumerator BeginningText()
		{
				yield return new WaitForSeconds (4f);
				firstText.text = "";
				secondText.text = ("It might have saved time.");
				thirdText.text = "";

				StartCoroutine (BeginningText2 ());
		}

		IEnumerator BeginningText2()
		{
				yield return new WaitForSeconds (3f);
				firstText.text = "";
				secondText.text = "";
				thirdText.text = ("Oh well, might as well get some\nrevenge while I am here.");
				Invoke ("EndText", WaitSecondTime);

		}

		void EndText()
		{
				firstText.text = "";
				secondText.text = "";
				thirdText.text = "";

				player.speed = 6;

		}


}