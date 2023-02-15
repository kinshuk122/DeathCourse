using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject checkpoint;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(checkpoint);

    }

}
