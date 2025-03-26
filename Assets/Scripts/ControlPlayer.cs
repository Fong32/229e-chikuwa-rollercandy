using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    private Rigidbody _rb;
    void Start()
    {
      _rb = GetComponent<Rigidbody>();  
    }
    void Update()
    {
        float moveX = 0f;
        float moveY = 0f;
        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
         moveX = -1;  
        }
        if (Input.GetKey(KeyCode.D))
        {
          moveX = 1; 
        }
        _rb.velocity = new Vector3 (moveX * moveSpeed, _rb.velocity.y, moveY * rotationSpeed);
    }
    
}
