using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    public float speed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
    }
    void Update()
    {
        // Vector3 pos = transform.position;
        // pos.y += Input.GetAxis("Vertical") *  speed * Time.deltaTime;
        // pos.x += Input.GetAxis("Horizontal") *  speed * Time.deltaTime;
        // transform.position = pos;
        if(transform.position.y >=4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);
        } else if(transform.position.y <= -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }
        if(transform.position.x >=10)
        {
            transform.position = new Vector3(10, transform.position.y, 0);
        } else if(transform.position.x <= -10)
        {
            transform.position = new Vector3(-10, transform.position.y, 0);
        }

        transform.Translate(Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal"));
        transform.Translate(Vector3.up * Time.deltaTime * speed * Input.GetAxis("Vertical"));
    }

    void OnTriggerEnter2D(Collider2D col) {
        if (col.tag =="Obstacle")
        {
            FindObjectOfType<GameManager>().EndGame();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
