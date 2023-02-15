using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TextTrap : MonoBehaviour
{
    public GameObject text;


    void Start()
    {
        text.GetComponent<Rigidbody>().useGravity = false;
        text.GetComponent<Collider>().enabled = false;
    }

    private void OnTriggerEnter()
    {
        if (CompareTag("Player")) { }
        {
            text.GetComponent<Rigidbody>().useGravity = true;
            text.GetComponent<Collider>().enabled = true;
        }
    }


}
