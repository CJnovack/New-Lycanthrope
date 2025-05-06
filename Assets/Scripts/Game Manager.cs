using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private int score = 50;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    public GameObject titleScreen;
    public Button startButton;
    public Text Score;
    public bool isGameActive;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        score = 50;
        UpdateScore(0);
        isGameActive = true;
        
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

    public void StartGame()
    {
     //   titleScreen.gameObject.SetActive(false);
       // Time.timeScale = 1f;
        //startButton.gameObject.SetActive(false);
    }

    private void Awake()
    {
        //Time.timeScale = 0f;
    }

    private void OnEnable()
    {
        //startButton.onClick.AddListener(StartGame);
    }

    private void OnDisable()
    {
        //startButton.onClick.RemoveListener(StartGame);
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
        CheckGameOver();
    }

    public void CheckGameOver()
    {
        if (score <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
}
