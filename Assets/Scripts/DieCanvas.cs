using System;
using UnityEngine;

public class DieCanvas : MonoBehaviour
{
    public GameObject canvas;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Blade"))
        {
            canvas.SetActive(true);
        }
    }
}
