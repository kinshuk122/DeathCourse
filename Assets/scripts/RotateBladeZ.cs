using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBladeZ : MonoBehaviour
{
    public float delta = 10f;
    public float speed = 6f;
    private Vector3 _startPos;

    private void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        transform.Rotate(0, 0, 5f);
        Vector3 v = _startPos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;

    }
}
