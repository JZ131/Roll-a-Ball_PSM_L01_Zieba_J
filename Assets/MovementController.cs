using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MovementController : MonoBehaviour
{
    public int score = 0;

    public GameObject points;

    public GameObject nextLevel;

    public float thrust = 5f;

    public Rigidbody rb;

    public Text scoreText;

    public Text winText;

    public void Score()
    {
        score += 1;
        scoreText.text = "Score: " + score;

        if (score == points.transform.childCount)
        {
            winText.text = "YOU WIN!!!";
            nextLevel.SetActive(true);
        }

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(2);
    }
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
