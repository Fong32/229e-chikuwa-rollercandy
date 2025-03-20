using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private float torgue;
    public float moveSpeed = 5f;
    private Rigidbody rb;
    void Start()
    {
      rb = GetComponent<Rigidbody>();  
    }
    
    void Update()
    {
        float move = 0f;
        
        if (Input.GetKey(KeyCode.A))
        {
           move = -1f; 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            move = 1f;
        }
        rb.velocity = new Vector3(move * moveSpeed, rb.velocity.y, move);
        rb.AddForce(0,0,10*force);
        rb.AddTorque(0,10*torgue,0);
    }
    
}
