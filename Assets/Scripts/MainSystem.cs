using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSystem : MonoBehaviour
{
    /// シューティングゲームを作りながら、自分のことについて話そうの会
    /// ジャンル:シューティングゲーム2D
    /// 画面遷移、シューティング、スコア
    
    /// 

    public Text scoreText;
    public Text resetText;
    public GameObject enemy;

    float timeCount = 0.0f;
    int spanCount = 0;

    float resetTime = 60;


    private void Start()
    {
        GameObject.Find("ScoreDirector").GetComponent<ScoreController>().score = 0;
    }
    private void Update()
    {
        scoreText.text = GameObject.Find("ScoreDirector").GetComponent<ScoreController>().ScoreText();

        timeCount += Time.deltaTime;

        if (timeCount >= 1)
        {
            timeCount = 0;
            spanCount++;
        }
        if (spanCount >= 5)
        {
            spanCount = 0;
            GameObject enemyChild = Instantiate(enemy);
            int runNumber = Random.Range(-9, 9);
            enemyChild.transform.position = new Vector3(runNumber, 7.5f, 0);
        }

        resetTime -= Time.deltaTime;
        resetText.text = resetTime.ToString("00");
        if (resetTime <= 10)
        {
            resetText.color = Color.red;
        }
        if (resetTime <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}