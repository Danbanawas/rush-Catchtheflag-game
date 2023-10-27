using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Cubeit: MonoBehaviour
{
    public float speed = 0f;
    public Rigidbody rb;
    private float horizonatalU;
    private float verticalU;
    //----------------------------
    public string inputH;
    public string inputV;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizonatalU = Input.GetAxisRaw(inputH);
        verticalU = Input.GetAxis(inputV);
    }

    //Vector3 move = new Vector3(  horizonatalU  ,  -.1f ,  verticalU );

    void FixedUpdate()
    {
        rb.velocity = new Vector3(horizonatalU, 0f, verticalU) * speed * Time.fixedDeltaTime;
    }

}
