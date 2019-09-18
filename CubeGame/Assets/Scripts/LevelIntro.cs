using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelIntro : MonoBehaviour {

   public Text levelText;

    private GameObject levelImage;

    private float LevelStartDelay = 2f;

	private float OtherWaitTime = 2f;

	public Text arrowKeys;

	public Text firstText;
	
		public bool CanMove;

	void Start () {

	
        //levelImage = GameObject.Find("LevelStart");
        //levelImage.SetActive(true);
        //levelText = GameObject.Find("LevelText").GetComponent<Text>();

        //Invoke("HideLevelImage", LevelStartDelay);

		arrowKeys.text = "";
		firstText.text = "Hey! Give Me Back that \nIce Cream Right Now!";
		Invoke("PushOutText", OtherWaitTime);

				CanMove = false;

    }


    private void HideLevelImage()
    {
        levelImage.SetActive(false);

    }
	
	void PushOutText()
	{
			firstText.text = "";
			arrowKeys.text = "Use the Arrow Keys to move";
				CanMove = true;
	}
}
