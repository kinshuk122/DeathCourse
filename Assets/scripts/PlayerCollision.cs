using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private const string Obstacle = "Obstacle";
    public PlayerMovement playerMovement;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


    void OnCollisionEnter(Collision player)
    {
        if (player.collider.CompareTag(Obstacle))
        {
            playerMovement.enabled = false;
            anim.Play("Death");
            FindObjectOfType<GameManager>().Relive();
        }
    }


}
