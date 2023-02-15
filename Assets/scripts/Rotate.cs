using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    void Update()
    {
        transform.localEulerAngles = new Vector3(Mathf.PingPong(Time.time * 60, 90), 0, 0);
    }
}
