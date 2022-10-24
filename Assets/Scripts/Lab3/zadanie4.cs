using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    public float speed = 2.0f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 velocity = new Vector3(moveHorizontal, 0, moveVertical);
        velocity = velocity.normalized * speed * Time.deltaTime;
        rb.MovePosition(transform.position + velocity);
    }
}
