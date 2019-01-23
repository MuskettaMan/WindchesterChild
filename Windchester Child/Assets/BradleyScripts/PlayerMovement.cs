using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float minSpeed = 3.5f;
    [SerializeField] private float speed;
    [SerializeField] private float maxSpeed = 4;
    InputManager inputManager = new InputManager();
    private new Rigidbody2D rigidbody;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }
    void Movement()
    {
        if (inputManager.Up && (!inputManager.Left || !inputManager.Right))
        {

            rigidbody.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);

        }

        if (inputManager.Down && (!inputManager.Left || !inputManager.Right))
        {
            rigidbody.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);

        }

       
        if (inputManager.Right && (!inputManager.Up || !inputManager.Down))
        {
            rigidbody.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);

        }
        if (inputManager.Left && (!inputManager.Up|| !inputManager.Down))
        { 
            rigidbody.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);

        }

        
        //diagonals
        if (inputManager.Up && inputManager.Right)
        {
            rigidbody.MovePosition(transform.position + new Vector3(1,1,0) * speed * Time.deltaTime);
        }

        if (inputManager.Up && inputManager.Left)
        {
            rigidbody.MovePosition(transform.position + new Vector3(-1, 1, 0) * speed * Time.deltaTime);
        }

        if (inputManager.Down && inputManager.Right)
        {
            rigidbody.MovePosition(transform.position + new Vector3(1, -1, 0) * speed * Time.deltaTime);
        }

        if (inputManager.Down && inputManager.Left)
        {
            rigidbody.MovePosition(transform.position + new Vector3(-1, -1, 0) * speed * Time.deltaTime);
        }


        //cancel opposing forces
        if ((inputManager.Up && inputManager.Down) || (inputManager.Left && inputManager.Right))
        {
            rigidbody.MovePosition(transform.position + Vector3.zero * speed * Time.deltaTime);
        }

        //acceleration
        if (inputManager.Up || inputManager.Down || inputManager.Left|| inputManager.Right)
        {
            if (speed < maxSpeed) speed += 0.02f; 
        }
        else
        {

            speed = minSpeed;

        } 
    }
}
