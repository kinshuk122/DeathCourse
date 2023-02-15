using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer1 : MonoBehaviour
{
    public GameObject player;
    public Transform players;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
        transform.position = players.position + offset;
    }
}
