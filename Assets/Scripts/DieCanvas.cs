using System;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject canvas3;
    public AudioSource audio1;
    public AudioSource audio2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blade"))
        {
            canvas.SetActive(true);
            canvas2.SetActive(false);
            audio1.Play();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            canvas2.SetActive(false);
            canvas3.SetActive(true);
            Destroy(gameObject);
            audio2.Play();

        }
    }
} 

