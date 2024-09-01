using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultChangeSystem : MonoBehaviour
{
    public Text scoreText;

    void Start()
    {
        scoreText.text = GameObject.Find("ScoreDirector").GetComponent<ScoreController>().ScoreText();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }
}
