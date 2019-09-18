using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb2d;

    public float speed = 6f;

    public Text WinText;

    public GameObject WinButton;

    public bool onTop;

    public Vector2 TrampolineVelocity;

	public float SpaceTime = 4f;

	public GravityUpController Gup;



		private LevelIntro lvlint;

	
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        WinText.text = "";
        WinButton.gameObject.SetActive(false);
		Gup = FindObjectOfType<GravityUpController> ();
		lvlint = FindObjectOfType<LevelIntro> ();

	}
	
	
	void Update () {
	
	}

    void FixedUpdate()
    {
				if (lvlint.CanMove == true) {
						float moveHorizontal = Input.GetAxis("Horizontal");
						Vector2 move = new Vector2 (moveHorizontal, 0);
						rb2d.AddForce (move * speed);
				}


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Trampoline")
        {
            onTop = true;
        }

        if(other.name == "EndOfLevel")
        {
            WinText.text = "LevelComplete";
            WinButton.gameObject.SetActive(true);
            speed = 0;
        }

		if (other.name == "Gravity Up") {
						
		rb2d.gravityScale = 0.3f;
		Invoke ("ReGravitate", SpaceTime);
					

		}


    }


    void OnCollisionStay2D(Collision2D other)
    {
        if(onTop == true)
        {
            Jump();
        }
    }
    void OnTriggerExit2D()
    {
        onTop = false;
    }


    public void Jump()
    {
        rb2d.velocity = TrampolineVelocity;
    }

	public void ReGravitate()
		{
				rb2d.gravityScale = 0.6f;

		}



}
