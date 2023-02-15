using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public GameObject trap;
    public GameObject trap2;
    public GameObject trap3;
    public GameObject trap4;

    private void Start()
    {
        trap.GetComponent<Rigidbody>().useGravity = false;
        trap.GetComponent<Collider>().enabled = false;

        trap2.GetComponent<Rigidbody>().useGravity = false;
        trap2.GetComponent<Collider>().enabled = false;

        trap3.GetComponent<Rigidbody>().useGravity = false;
        trap3.GetComponent<Collider>().enabled = false;

        trap4.GetComponent<Rigidbody>().useGravity = false;
        trap4.GetComponent<Collider>().enabled = false;
    }

    private void OnTriggerEnter()
    {
        if(CompareTag("Player")) { }
        {
            trap.GetComponent<Rigidbody>().useGravity = true;
            trap.GetComponent<Collider>().enabled = true;

            trap2.GetComponent<Rigidbody>().useGravity = true;
            trap2.GetComponent<Collider>().enabled = true;

            trap3.GetComponent<Rigidbody>().useGravity = true;
            trap3.GetComponent<Collider>().enabled = true;

            trap4.GetComponent<Rigidbody>().useGravity = true;
            trap4.GetComponent<Collider>().enabled = true;
        }
    }
}
