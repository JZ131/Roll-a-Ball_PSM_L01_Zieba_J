using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collectible : MonoBehaviour
{
    private AudioSource audioData;

    private BoxCollider pointCollider;

    private MeshRenderer mr;

    void Start()
    {
        audioData = GetComponent<AudioSource>();
        pointCollider = GetComponent<BoxCollider>();
        mr = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 30, Time.deltaTime * 15);
    }

    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<MovementController>().Score();

        audioData.Play();
        pointCollider.enabled = false;
        mr.enabled = false;
        

        /*gameObject.SetActive(false);*/
    }
}
