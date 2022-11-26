using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public float distance = 2.5f;
    public float doorSpeed = 2f;
    private float openPosition;
    private bool isOpen= false;

    void Start()
    {
        openPosition = transform.position.x + distance;
    }

    void Update()
    {
        if(isOpen)
        {
            Vector3 move = transform.right * doorSpeed * Time.deltaTime;
            if(transform.position.x <= openPosition)
            {
                transform.Translate(move);
            }
        }

    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player podszedł do drzwi.");
            isOpen = true;
        }
    }
}
