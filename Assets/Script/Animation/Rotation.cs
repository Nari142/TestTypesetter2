using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 axis = new Vector3(0, 0, 1);
    [SerializeField] Transform point;

    void Update()
    {
        transform.RotateAround(point.position, axis, speed * Time.deltaTime);
    }
}
