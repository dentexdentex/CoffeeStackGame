using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    public float force;
    private void OnTriggerEnter(Collider other)
    {
        //other.gameObject.AddComponent<Rigidbody>();
        if (other.gameObject.tag == "Cube") { 
            other.gameObject.GetComponent<Rigidbody>().isKinematic = false;

            GetComponent<Rigidbody>().AddForce(force, 0, 0);
        }
    }
}
