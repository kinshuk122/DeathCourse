using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGmusic : MonoBehaviour
{
    private static BGmusic backgroundmusic;

    void Awake()
    {
        if(backgroundmusic == null)
        {
            backgroundmusic = this;
            DontDestroyOnLoad(backgroundmusic);
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
