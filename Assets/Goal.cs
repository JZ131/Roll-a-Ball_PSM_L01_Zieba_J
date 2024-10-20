using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 45, Time.deltaTime * 23);
    }
    void OnTriggerEnter(Collider collider)
    {
        collider.gameObject.GetComponent<MovementController>().score += 1;

        Debug.Log("+1 point");
        Debug.Log("score: " + collider.gameObject.GetComponent<MovementController>().score);

            Debug.Log("Congratulations you have reached the end point!!!! Your final score is: " + collider.gameObject.GetComponent<MovementController>().score);
        

        gameObject.SetActive(false);
    }
    
}
