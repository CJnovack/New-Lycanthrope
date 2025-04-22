using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int score = 50;
    public TextMeshProUGUI scoreText;
    public Text Score;
    // Start is called before the first frame update
    void Start()
    {
        score = 50;
        UpdateScore(0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Food")
        {
            score += 10;
           // Destroy(other.gameObject);
            UpdateScoreText();
        }
    }
    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Energy: " + score;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            
        }
    }

    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Energy: " + score;
    }
}
