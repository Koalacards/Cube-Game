using UnityEngine;
using System.Collections;

public class SpeederUpperController : MonoBehaviour
{



    private PlayerController player;

    public float CooldownTime = 4f;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Protagonist")
        {
            this.gameObject.SetActive(false);
            player.speed = 8;
            Invoke("ReturnOriginal", CooldownTime);

        }

    }
    public void ReturnOriginal()
    {
        this.gameObject.SetActive(true);
        player.speed = 6;
    }

}