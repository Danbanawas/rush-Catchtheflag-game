using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class Anotha : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 1f;
    private Rigidbody rb;
    private PlayerInput Playerr;
    private bool isjumping;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Playerr = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveinput2 = Playerr.actions["Move2"].ReadValue<Vector3>();
        transform.Translate(moveinput2* Time.deltaTime);
        transform.Translate(moveinput2 * Time.deltaTime * 5);
     
        if (Input.GetButton("Jump") && !isjumping)
        {
            rb.AddForce(0, 100, 0, ForceMode.Impulse);
            isjumping = true;
        }
        if(Input.GetKey(KeyCode.JoystickButton3))
        {
            rb.AddForce(0, 100, 0);
        }
        rb.MovePosition(transform.position + moveinput2);

    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            rb.AddForce(0, 100, 0);
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



