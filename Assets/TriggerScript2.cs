using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("LTrigger"))
        {
            Debug.Log("Sphere entered LTrigger.");
        }
        else if (other.gameObject.CompareTag("RTrigger"))
        {
            Debug.Log("Sphere entered RTrigger.");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("LTrigger"))
        {
            Debug.Log("Sphere is still in LTrigger.");
        }
        else if (other.gameObject.CompareTag("RTrigger"))
        {
            Debug.Log("Sphere is still in RTrigger.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("LTrigger"))
        {
            Debug.Log("Sphere exited LTrigger.");
        }
        else if (other.gameObject.CompareTag("RTrigger"))
        {
            Debug.Log("Sphere exited RTrigger.");
        }
    }
}
