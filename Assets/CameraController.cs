using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject camera;
    public GameObject player;
    public MovementController playerController;
    public Vector3 cameraPosition;

    void Start()
    {
        cameraPosition = camera.transform.position - player.transform.position;
    }

    void Update()
    {
        camera.transform.position = cameraPosition + player.transform.position;
    }
}
