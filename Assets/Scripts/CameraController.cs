using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    Vector3 cameraPosition;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        cameraPosition = player.position - transform.position;
    }

    void Update()
    {
        transform.position = player.position - cameraPosition;
    }
}
