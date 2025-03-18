using System;
using UnityEngine;

public class HitBlade : MonoBehaviour
{
    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.CompareTag("Blade"))
        {
          Destroy(gameObject);
        }
    }
}
