using UnityEngine;

public class Point : MonoBehaviour
{
  public CollectPoint collectPoint;
  public CollectPoint collectPoint2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
        collectPoint.AddPoint();
        collectPoint2.AddPoint();
    }
}
