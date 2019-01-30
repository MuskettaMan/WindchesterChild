﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementNew : MonoBehaviour {

    public float speed {
        get {
            return _speed;
        }
        set {
            _speed = value;
        }
    }

    private float _speed;

    private Rigidbody2D rb2d;

    private void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        Vector2 move = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        rb2d.velocity = move * _speed * Time.deltaTime;
    }

}
