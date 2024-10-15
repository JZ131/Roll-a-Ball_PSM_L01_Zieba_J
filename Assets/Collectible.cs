using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0, 2, 1);
    }

    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<MovementController>().score += 1;

        Debug.Log("+1 point");
        Debug.Log("score: " + collider.gameObject.GetComponent<MovementController>().score);
        
        if (collider.gameObject.GetComponent<MovementController>().score == 6)
        {
            Debug.Log("Congratulations you have collected all points!!!");
        }

        gameObject.SetActive(false);
    }
}
