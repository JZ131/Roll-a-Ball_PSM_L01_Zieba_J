using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Collectible : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 30, Time.deltaTime * 15);
    }

    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<MovementController>().Score();

        gameObject.SetActive(false);
    }
}
