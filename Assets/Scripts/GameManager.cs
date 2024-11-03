using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GameObject[] points;

    int maxScore;


    void Start()
    {
        points = GameObject.FindGameObjectsWithTag("Point");

        maxScore = points.Length;
    }

}
