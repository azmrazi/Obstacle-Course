using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    MeshRenderer renderer;
    Rigidbody rb;
    [SerializeField] float timeToFall;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;

        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    void Update()
    {
        if (Time.time > timeToFall)
        {
            GetComponent<MeshRenderer>().enabled = true;
            GetComponent<Rigidbody>().useGravity = true;
        }
    }

}
