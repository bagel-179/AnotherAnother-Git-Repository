using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public GameObject playerPrefab;
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab;
    public GameObject enemyThreePrefab;
    public GameObject cloudPrefab;
    public GameObject katCoinPrefab;
    public GameObject healthBoostPrefab;
    public int score;
    public int cloudsMove;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab, transform.position, Quaternion.identity);
        CreateSky();
        InvokeRepeating("SpawnEnemyOne", 1.0f, 3.0f);
        InvokeRepeating("CreateEnemyTwo", 3.0f, 4.5f);
        InvokeRepeating("CreateEnemyThree", 5.0f, 4.0f);
        InvokeRepeating("KatCoin", 3.0f, 5.0f);
        InvokeRepeating("CreateHealthBoost", 10.0f, 7.0f);
        cloudsMove = 1;
        score = 0;
        scoreText.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemyOne()
    {
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-8, 8), 7.5f, 0), Quaternion.Euler(0, 0, 180));
    }

    void CreateEnemyTwo()
    {
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
    }

    void CreateEnemyThree()
    {
        Instantiate(enemyThreePrefab, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
    }

    void KatCoin()
    {
        Instantiate(katCoinPrefab, new Vector3(Random.Range(-7, 7), 7, 0), Quaternion.identity);
    }

    void CreateSky()
    {
        for (int i = 0; i < 50; i++) 
        {
            Instantiate(cloudPrefab, new Vector3(Random.Range(-11f, 11f), Random.Range(-7.5f, 7.5f), 0), Quaternion.identity);
        }
    }

    void CreateHealthBoost()
    {
        Instantiate(healthBoostPrefab, new Vector3(Random.Range(-7.5f, 7.5f), Random.Range(-3, 0), 0), Quaternion.identity);
        Destroy(GameObject.FindWithTag("Health"), 7);
    }

    public void GameOver()
    {
        CancelInvoke();
        cloudsMove = 0;
    }

    public void EarnScore(int scoreToAdd)
    {
        score = score + scoreToAdd;
        scoreText.text = "Score: " + score;
    }
}
