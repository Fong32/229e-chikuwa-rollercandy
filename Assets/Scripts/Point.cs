using UnityEngine;

public class Point : MonoBehaviour
{
  public CollectPoint collectPoint;
  public CollectPoint collectPoint2;
  public CollectPoint collectPoint3;
  public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            sound.Play();
            
        }
        collectPoint.AddPoint();
        collectPoint2.AddPoint();
        collectPoint3.AddPoint();
    }
}
