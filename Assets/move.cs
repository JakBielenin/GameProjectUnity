using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float move_speed;
    private Rigidbody2D rgbody;
    private Vector3 move_direction;
    private Vector3 set_roation;

    float rotation = 0;

    void Start()
    {
        rgbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveX = 0;
        float moveY = 0;

        if (Input.GetKey(KeyCode.W))
        {
            moveY = 1f;
            rotation = 0;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveY = -1f;
            rotation = 180;

        }
        if (Input.GetKey(KeyCode.A))
        {
            moveX = -1f;
            rotation = 90;

        }
        if (Input.GetKey(KeyCode.D))
        {
            moveX = 1f;
            rotation = 270;
        }



        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
        {
            rotation = 45;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            rotation = 135;

        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            rotation = 225;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
        {
            rotation = 315;
        }
        move_direction = new Vector3(moveX, moveY).normalized;
        set_roation = new Vector3(0, 0, rotation);
    }

    private void FixedUpdate()
    {
        rgbody.velocity = move_direction * move_speed;
        transform.rotation = Quaternion.Euler(set_roation);
    }
}
