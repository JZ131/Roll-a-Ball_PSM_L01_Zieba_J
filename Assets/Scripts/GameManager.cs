using Unity.VisualScripting;
/*using UnityEditor.SearchService;*/
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEditor.Timeline.TimelinePlaybackControls;
using UnityEngine.SocialPlatforms.Impl;



public class GameManager : MonoBehaviour
{

    GameObject[] points;
    int maxScore;
    Scene scene;

    
    public void NextLevel()
    {
        SceneManager.LoadScene(scene.buildIndex + 1);
    }

    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("Point");
        maxScore = points.Length;
        scene = SceneManager.GetActiveScene();
    }

}
