using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    int moveSpeed = 4;

    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime;

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
