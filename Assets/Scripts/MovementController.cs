using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;
using System;
public class MovementController : MonoBehaviour
{
    public event Action pickupEvent;

    private float thrust = 5f;

    private Rigidbody rb;

    [SerializeField]
    private GameObject points;

    public int score = 0;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private Text winText;

    [SerializeField]
    private GameObject nextLevel;
    public void Score()
    {
        score += 1;

        pickupEvent?.Invoke();

        /*scoreText.text = "Score: " + score;*/

        if (score == points.transform.childCount)
        {
            winText.text = "YOU WIN!!!";
            nextLevel.SetActive(true);
        }

    }


    private void MovementUpdate(){
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

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        MovementUpdate();
    }
}
