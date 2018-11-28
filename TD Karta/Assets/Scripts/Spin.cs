using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public enum RotationAxes
    {
        MouseX = 1,
    }

    public RotationAxes axes = RotationAxes.MouseX;

    public float sensitivityHor = 9.0f;

    void Start()
    {
        //Rigidbody body = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (axes == RotationAxes.MouseX)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * -sensitivityHor, 0);
        }

    }
}
