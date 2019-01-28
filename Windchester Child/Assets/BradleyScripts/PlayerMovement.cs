using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float minSpeed = 3;
    [SerializeField] private float currentSpeed;
    [SerializeField] private float speedIncrease;
    [SerializeField] private float maxSpeed = 5;
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

            rigidbody.MovePosition(transform.position + Vector3.up * currentSpeed * Time.deltaTime);

        }

        if (inputManager.Down && (!inputManager.Left || !inputManager.Right))
        {
            rigidbody.MovePosition(transform.position + Vector3.down * currentSpeed * Time.deltaTime);

        }


        if (inputManager.Right && (!inputManager.Up || !inputManager.Down))
        {
            rigidbody.MovePosition(transform.position + Vector3.right * currentSpeed * Time.deltaTime);

        }
        if (inputManager.Left && (!inputManager.Up|| !inputManager.Down))
        {
            rigidbody.MovePosition(transform.position + Vector3.left * currentSpeed * Time.deltaTime);

        }


        //diagonals
        if (inputManager.Up && inputManager.Right)
        {
            rigidbody.MovePosition(transform.position + new Vector3(1,1,0) * currentSpeed * Time.deltaTime);
        }

        if (inputManager.Up && inputManager.Left)
        {
            rigidbody.MovePosition(transform.position + new Vector3(-1, 1, 0) * currentSpeed * Time.deltaTime);
        }

        if (inputManager.Down && inputManager.Right)
        {
            rigidbody.MovePosition(transform.position + new Vector3(1, -1, 0) * currentSpeed * Time.deltaTime);
        }

        if (inputManager.Down && inputManager.Left)
        {
            rigidbody.MovePosition(transform.position + new Vector3(-1, -1, 0) * currentSpeed * Time.deltaTime);
        }


        //cancel opposing forces
        if ((inputManager.Up && inputManager.Down) || (inputManager.Left && inputManager.Right))
        {
            rigidbody.MovePosition(transform.position + Vector3.zero * currentSpeed * Time.deltaTime);
        }

        //acceleration
        if (inputManager.Up || inputManager.Down || inputManager.Left|| inputManager.Right)
        {
            if (currentSpeed < maxSpeed) currentSpeed += speedIncrease;
        }
        else
        {

            currentSpeed = minSpeed;

        }
    }
}
