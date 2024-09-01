using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private static ScoreController instance;
    public static ScoreController Instance => instance;


    public int score = 0;

    private void Awake()
    {
        if (instance&&this !=instance)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(this);
    }

    public string ScoreText()
    {
        return "Score: " + score.ToString("00000000");
    }
}