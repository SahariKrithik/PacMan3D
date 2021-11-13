using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDie : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Harmful Trap")
            PlayerDie();
    }
    public void PlayerDie()
    {
        Destroy(gameObject);
    }
}
