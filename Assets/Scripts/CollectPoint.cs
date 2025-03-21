using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CollectPoint : MonoBehaviour
{
    public Text ScoreText;
    private int score = 0;

    public void AddPoint()
    {
        score += 1;
        ScoreText.text = "Score: " + score;
    }
}
