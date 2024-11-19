using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    private MovementController player;

    [SerializeField]
    private Text scoreText;

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + player.score;
    }

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();
        
        player.pickupEvent += UpdateScoreText;
    }
}
