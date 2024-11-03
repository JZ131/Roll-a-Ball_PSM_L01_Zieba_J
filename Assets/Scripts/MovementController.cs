using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class MovementController : MonoBehaviour
{
    public event Action pickupEvent;

    public int score = 0;

    public GameObject points;

    public GameObject nextLevel;

    public float thrust = 5f;

    public Rigidbody rb;

    public Text scoreText;

    public Text winText;

    public int current_level = 1;

    Scene scene;

    public void Score()
    {
        score += 1;

        pickupEvent();

        scoreText.text = "Score: " + score;

        if (score == points.transform.childCount)
        {
            winText.text = "YOU WIN!!!";
            current_level = current_level + 1;
            nextLevel.SetActive(true);
        }

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
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

        scene = SceneManager.GetActiveScene();

    }

    void FixedUpdate()
    {
        MovementUpdate();
    }
}
