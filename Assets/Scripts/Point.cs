using UnityEngine;

public class Point : MonoBehaviour
{
  public CollectPoint collectPoint;
  public CollectPoint collectPoint2;
  public CollectPoint collectPoint3;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            
        }
        collectPoint.AddPoint();
        collectPoint2.AddPoint();
        collectPoint3.AddPoint();
    }
}
