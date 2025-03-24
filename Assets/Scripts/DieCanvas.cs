using System;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;
    public GameObject canvas3;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blade"))
        {
            canvas.SetActive(true);
            canvas2.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            canvas2.SetActive(false);
            canvas3.SetActive(true);
            Destroy(gameObject);

        }
    }
} 

