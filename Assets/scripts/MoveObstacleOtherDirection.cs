using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObstacleOtherDirection : MonoBehaviour
{
    public float delta = 10f;
    public float speed = 6f;
    private Vector3 _startPos;

    void Start()
    {
        _startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = _startPos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}
