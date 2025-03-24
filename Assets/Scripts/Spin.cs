using UnityEngine;

public class Spin : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV;
    void Start()
    {
     rb=GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
     rb.angularVelocity = angularV; 
    }
}
