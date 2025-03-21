using System;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject canvas2;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blade"))
        {
            canvas.SetActive(true);
            canvas2.SetActive(false);
        }
    }
}
