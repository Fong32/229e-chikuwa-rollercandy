using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CollectPoint : MonoBehaviour
{
    public Text scoreText;
    private int _score = 0;

    public void AddPoint()
    {
        _score += 1;
        scoreText.text = "Score: " + _score;
    }
}
