using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public GameObject jewel;
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(jewel);
    }
}
