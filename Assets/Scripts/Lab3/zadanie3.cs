using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 1f;
    private Vector3 target;
    private int direction = 0;
    private Vector3 newRotation;
    int rotation = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if(direction == 0)
        {
            target = new Vector3(10.0f, 0.0f, 0.0f);
        }
        if(direction == 1)
        {
            target = new Vector3(10.0f, 0.0f, 10.0f);
        }
        if(direction == 2)
        {
            target = new Vector3(0.0f, 0.0f, 10.0f);
        }
        if(direction == 3)
        {
            target = new Vector3(0.0f, 0.0f, 0.0f);
        }

        transform.position = Vector3.MoveTowards(transform.position, target, step);
        if (Vector3.Distance(transform.position, target) < 1f)
        {
            direction++;
            rotation = 90 - rotation;
            newRotation = new Vector3(rotation, 0, rotation);
            transform.eulerAngles = newRotation;
            if(direction==4){
                direction = 0;
            }
        }
    }
}