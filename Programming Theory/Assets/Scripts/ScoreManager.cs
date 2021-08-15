using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private TextMeshProUGUI scoreText;
    public IItem itemScore;

    void Start()
    {
        itemScore = gameObject.GetComponent<IItem>();
    }

    public void AddScore()
    {
        score += (int)(itemScore.scoreAmount * itemScore.scoreMultiplier);
        UpdateUI();
    }

    private void UpdateUI()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
