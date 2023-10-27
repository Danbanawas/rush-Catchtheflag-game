using GLTFast.Schema;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Pool;

public class Moveme : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 10000f;
    private Rigidbody rb;
    private PlayerInput Playerr;
    private bool isjumping;
    Animator anim;

    private void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }
   
    void Start()
    {
        rb= GetComponent<Rigidbody>();
        Playerr = GetComponent<PlayerInput>();
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveinput = Playerr.actions["Move3"].ReadValue<Vector3>();
        transform.Translate(moveinput*Time.deltaTime*2);
        transform.Translate(moveinput * Time.deltaTime*5);
        if (Input.GetKeyDown(KeyCode.Z) && !isjumping)
        {
            rb.AddForce(0, 100, 0, ForceMode.Impulse);
            isjumping = true;
            
        }
        if (Input.GetKey(KeyCode.F))
        {
            rb.AddForce(0, 100, 0);
        }
        
        rb.MovePosition(transform.position + moveinput);



    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            rb.AddForce(0, 100, 0);
        }
        /*
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontal * speed * 5 * Time.deltaTime, 0, vertical * speed * 5 * Time.deltaTime);
        rb.MovePosition(transform.position + movement);*/
    }
    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isjumping = false;
        }
    }
}
