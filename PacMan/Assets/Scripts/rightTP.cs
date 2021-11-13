using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightTP : MonoBehaviour
{
    public GameObject playerObject;
    public Transform teleportTo;
    public Collider otherTPCollider;
    void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerObject.transform.position = teleportTo.transform.position;
            otherTPCollider.isTrigger = true;
            StartCoroutine(delay());
        }
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
        otherTPCollider.isTrigger = false;
    }
}
