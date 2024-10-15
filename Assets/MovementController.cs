using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public int score;

    public float thrust = 5f;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 20, 0);
        }

        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(0, 0, thrust);
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-thrust, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(0, 0, -thrust);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(thrust, 0, 0);
        }
    }
}
