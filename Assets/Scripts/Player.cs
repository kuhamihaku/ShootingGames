using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject ball;

    int moveSpeed = 5;

    private void Update()
    {
        int x_p=0;
        int x_m=0;
        int y_p=0;
        int y_m=0;

        if (Input.GetKey(KeyCode.D)) x_p = 1;
        if (Input.GetKey(KeyCode.A)) x_m = -1;
        if (Input.GetKey(KeyCode.W)) y_p = 1;
        if (Input.GetKey(KeyCode.S)) y_m = -1;

        int x = x_p + x_m;
        int y = y_p + y_m;

        transform.position += new Vector3(x, y, 0) * moveSpeed * Time.deltaTime;

        Vector3 pos = transform.position;
        pos.x = pos.x < -9 ? -9 : pos.x > 9 ? 9 : pos.x;
        pos.y = pos.y < -4 ? -4 : pos.y > 5 ? 5 : pos.y;
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(ball, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Destroy(gameObject);
            Destroy(collision.gameObject);
            SceneManager.LoadScene(2);
        }
    }
}