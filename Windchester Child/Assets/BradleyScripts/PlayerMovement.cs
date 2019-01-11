using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1;
  
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)))
        {
            
            Vector2 move = transform.position += Vector3.up *speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }

        if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)))
        {
            Vector2 move = transform.position += Vector3.down * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
        if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)))
        {
            Vector2 move = transform.position += Vector3.right * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
        if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)))
        {
            Vector2 move = transform.position += Vector3.left * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
    }
}
