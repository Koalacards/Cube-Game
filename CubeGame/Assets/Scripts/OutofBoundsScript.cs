using UnityEngine;
using System.Collections;

public class OutofBoundsScript : MonoBehaviour
{
    public GameObject Checkpoint;

    private PlayerController player;

    void Start()
    {
        player = FindObjectOfType<PlayerController>();

    }

    public void RespawnPlayer()
    {
        player.transform.position = Checkpoint.transform.position;
        player.transform.rotation = Checkpoint.transform.rotation;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Protagonist")
        {
            RespawnPlayer();
        }
    }
}
