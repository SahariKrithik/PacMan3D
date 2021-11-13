using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    Rigidbody rb;
    public float playerSpeed = 0.1f;
    bool turning;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        turning = false;
        
    }

    void FixedUpdate()
    {
        if (!turning) //turning off freezeconstraint if not turning
        {
            rb.constraints = RigidbodyConstraints.None;
            Vector3 forwardMove = transform.forward * playerSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMove);

        }
       


    }
     void Update()
    {
        turn();
    }

    void turn()
    {

        if (Input.GetKeyDown(KeyCode.A)) //leftTurn
        {
            turning = true;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.rotation = Quaternion.Euler(0, -90, 0);
        }
        else
            turning = false;

        if (Input.GetKeyDown(KeyCode.D)) //rightTurn
        {
            turning = true;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.rotation = Quaternion.Euler(0, 90, 0); 
        }
        else
            turning = false;

        if (Input.GetKeyDown(KeyCode.W)) //ForwardTurn
        {
            turning = true;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
            turning = false;

        if (Input.GetKeyDown(KeyCode.S)) //ForwardTurn
        {
            turning = true;
            rb.constraints = RigidbodyConstraints.FreezePosition;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else
            turning = false;
    }
}
 