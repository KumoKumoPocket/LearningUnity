using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotJoint : MonoBehaviour
{
    public Vector3 Axis;
    public Vector3 StartOffset;

    public float MinAngle;
    public float MaxAngle;

    void Awake()
    {
        StartOffset = transform.localPosition;
    }

    internal void Rotate(float angle)
    {
        this.gameObject.transform.rotation = Quaternion.AngleAxis(angle, Axis);
    }
}

