using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie4 : MonoBehaviour
{
    // ruch wokół osi Y będzie wykonywany na obiekcie gracza, więc
    // potrzebna nam referencja do niego (konkretnie jego komponentu Transform)
    public Transform player;
    private float Min = -0.5f, Max = 0.5f;
    public float sensitivity = 200f;

    void Start()
    {
        // zablokowanie kursora na środku ekranu, oraz ukrycie kursora
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.rotation.eulerAngles.x < 90 &&  transform.rotation.eulerAngles.x > -90)
        {
            float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
            player.Rotate(Vector3.up * mouseXMove);
            transform.Rotate(new Vector3(Mathf.Clamp(-mouseYMove, Min, Max), 0f, 0f), Space.Self);
        }

    }
}
