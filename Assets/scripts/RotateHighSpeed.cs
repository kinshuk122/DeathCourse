using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHighSpeed : MonoBehaviour
{
    public void Update()
    {
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 90, 90), 0);
    }
}
