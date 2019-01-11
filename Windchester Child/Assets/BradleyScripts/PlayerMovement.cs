using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 1;
    InputManager inputManager = new InputManager();
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (inputManager.Up)
        {
            
            Vector2 move = transform.position += Vector3.up *speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }

        if (inputManager.Down)
        {
            Vector2 move = transform.position += Vector3.down * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
        if (inputManager.Right)
        {
            Vector2 move = transform.position += Vector3.right * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
        if (inputManager.Left)
        {
            Vector2 move = transform.position += Vector3.left * speed;
            GetComponent<Rigidbody2D>().MovePosition(move * Time.deltaTime);

        }
    }
}
