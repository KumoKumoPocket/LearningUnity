using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    public float speed = 5.0f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Vector3.forward * Input.GetAxis("Horizontal") * Time.deltaTime);
        transform.Translate(speed * Vector3.right * -Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
