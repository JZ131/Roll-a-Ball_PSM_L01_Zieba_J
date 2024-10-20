using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

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
        collider.gameObject.GetComponent<MovementController>().score += 1;

        Debug.Log("+1 point");
        Debug.Log("score: " + collider.gameObject.GetComponent<MovementController>().score);

        gameObject.SetActive(false);
    }
}
