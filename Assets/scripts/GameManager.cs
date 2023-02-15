using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 6f;
    public GameObject Win;
    public GameObject Respawn;

    public void Winning()
    {
        Win.SetActive(true);
    }

    public void Relive()
    {
        Respawn.SetActive(true);
    }

}
