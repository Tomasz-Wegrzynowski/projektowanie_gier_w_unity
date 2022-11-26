using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    int obstacleCount = 0;
    float Timer = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            obstacleCount = Random.Range(1, 3);
            for(int i =0; i< obstacleCount; i++)
            {
                Instantiate(obstacle, new Vector3(12, Random.Range(-5, 5), 0), Quaternion.identity);
            }
            Timer = 1f;
        }
    }
}
