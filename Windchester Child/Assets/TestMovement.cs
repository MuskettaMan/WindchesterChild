using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovement : MonoBehaviour
{

    public float speed = 5;
    private Rigidbody2D rb2d;

    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A)) {
            rb2d.MovePosition(transform.position + Vector3.left * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.D)) {
            rb2d.MovePosition(transform.position + Vector3.right * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.W)) {
            rb2d.MovePosition(transform.position + Vector3.up * speed * Time.deltaTime);
        }

        if(Input.GetKey(KeyCode.S)) {
            rb2d.MovePosition(transform.position + Vector3.down * speed * Time.deltaTime);
        }
    }
}
