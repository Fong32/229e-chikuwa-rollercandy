using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    [SerializeField] private float force;
    
    public float moveSpeed = 5f;
    private Rigidbody _rb;
    void Start()
    {
      _rb = GetComponent<Rigidbody>();  
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
        
        _rb.linearVelocity = new Vector3(move *moveSpeed,_rb.linearVelocity.y,move);
        _rb.AddForce(0,0,10*force);
        
    }
    
}
