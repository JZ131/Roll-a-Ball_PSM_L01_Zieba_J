using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject player;
    public GameObject teleportOut;

    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        player.transform.position = teleportOut.transform.position;
    }
}
