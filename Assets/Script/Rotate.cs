using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Rotate : MonoBehaviour
{

    [SerializeField] [Range(0,100)]private float rotationY = 0;
    [SerializeField] [Range(0,100)]private float rotationZ = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, Time.deltaTime * rotationY, Time.deltaTime * rotationZ, Space.Self);
    }
}
