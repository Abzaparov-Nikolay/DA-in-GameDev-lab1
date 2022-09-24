using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Cube")
        {
            Debug.Log("Cube has entered Sphere");
            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Cube")
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
