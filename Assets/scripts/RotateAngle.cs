using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAngle : MonoBehaviour
{

    public void Update()
    {
        transform.localEulerAngles = new Vector3(0, Mathf.PingPong(Time.time * 60, 90),0 );
    }
}
