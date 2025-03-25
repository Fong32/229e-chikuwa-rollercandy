using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

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
