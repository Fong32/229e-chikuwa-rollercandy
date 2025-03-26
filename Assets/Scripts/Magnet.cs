using System;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public float magnetForce = 50f;
    public float magnetRadius = 10f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
            {
              Vector3 direction = transform.position - other.transform.position;
              float distance = direction.magnitude;
              if (distance < magnetRadius)
              {
                float forceMagnitude = magnetForce;
                rb.AddForce(direction.normalized * forceMagnitude, ForceMode.Acceleration);
              }
            }   
        }
        
    }
}
