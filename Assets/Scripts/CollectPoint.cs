using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.UI;

public class CollectPoint : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void AddPoint()
    {
        score += 1;
        scoreText.text = "Score: " + score;
        
    }
    
}
