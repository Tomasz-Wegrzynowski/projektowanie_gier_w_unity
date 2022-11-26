using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    public float force = 10f;
    private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    // Start is called before the first frame update
    void Start()
    {
        jumpHeight = jumpHeight * force;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            Debug.Log("Player wszedł na platforme.");
            playerVelocity.y += gravityValue * Time.deltaTime;
            controller.Move(playerVelocity * Time.deltaTime);
        }
    }
}
