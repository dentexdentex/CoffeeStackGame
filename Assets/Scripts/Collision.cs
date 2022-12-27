using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Cube")
        {
            other.gameObject.AddComponent<Collision>();
            other.gameObject.GetComponent<Collider>().isTrigger = false;
            Rush.instance.cubes.Add(other.gameObject);
        }
    }
}
