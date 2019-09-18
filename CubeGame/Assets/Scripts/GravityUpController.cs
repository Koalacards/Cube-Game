using UnityEngine;
using System.Collections;

public class GravityUpController : MonoBehaviour {

    private PlayerController player;

   public float CooldownTime = 4f;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();
				player.GetComponent<Rigidbody2D> ();

    }
   void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Protagonist")
        {
            this.gameObject.SetActive(false);
			
            Invoke("ReturnOriginal", CooldownTime);

        }

    }
    public void ReturnOriginal()
    {
        this.gameObject.SetActive(true);
        player.speed = 6;
    }

}
