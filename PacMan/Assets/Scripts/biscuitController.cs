using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class biscuitController : MonoBehaviour
{
    public GameObject scoreHandler;  // an empty gameobject in hierarchy
    score scoreObject; // reference to the score script 
    void Start()
    {
        scoreHandler = GameObject.FindGameObjectWithTag("ScoreHandler"); 
        scoreObject = scoreHandler.GetComponent<score>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Player")
        {
            scoreObject.addScore();
            Destroy(gameObject);
        }
    }
}
