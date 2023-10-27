using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move: MonoBehaviour

{
    public float speed = 4.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    private bool isjumping;




    void Start()

    {
        playerRb = GetComponent<Rigidbody>();

    }


    void Update()
    {

        float verticalmovement = Input.GetAxis("Vertical1");
        float horizontalmovement = Input.GetAxis("Horizontal1");
        horizontalInput = Input.GetAxis("Vertical1");//setting the move with the keys
        forwardInput = Input.GetAxis("Horizontal1");


        //moving forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        //jump the player
        if (Input.GetKeyDown(KeyCode.Space) && !isjumping)
        {
            playerRb.AddForce(0, 100, 0, ForceMode.Impulse);
            isjumping = true;
        }
        

    }
    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
        }
    }

}

