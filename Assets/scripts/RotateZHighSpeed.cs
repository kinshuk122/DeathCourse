using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateZHighSpeed : MonoBehaviour
{
    public void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * 90, 90));
    }
}
