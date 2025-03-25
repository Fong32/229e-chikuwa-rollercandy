using System;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
          audioSource.Play();  
        }
    }
}
