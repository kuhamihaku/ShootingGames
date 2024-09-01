using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    int moveSpeed = 8;

    private void Update()
    {
        transform.position += new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime;

        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            GameObject.Find("ScoreDirector").GetComponent<ScoreController>().score += 100;
                
                //.Instance.score += 100;
        }
    }
}