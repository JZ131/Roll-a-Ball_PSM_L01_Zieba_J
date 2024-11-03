using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    [SerializeField]
    private GameObject player;

    [SerializeField]
    private Text scoreText;

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + player.score;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
}
