using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour

{

    public Transform PlatformTransform;
    public Transform PlayerTransform;
    public GameObject Platform;
    public GameObject Flame1;
    public GameObject Flame2;
    public Rigidbody rb;
    public bool isRising;
    public float Speed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        Platform.SetActive(false);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            StartCoroutine(JetpackUp());
        }
        
        if (Input.GetKey(KeyCode.JoystickButton2))
        {
            StartCoroutine(StopJetpack());
        }
    }

    IEnumerator JetpackUp()
    {

        isRising = true;
        Flame1.SetActive(true);
        Flame2.SetActive(true);
        // Platform.transform.SetParent(PlatformTransform);
        //PlatformTransform.GetComponent<Animator>().Play("jatbackk");

        //Platform.SetActive(true);
        yield return new WaitForSeconds(0.1f);

    }

    IEnumerator StopJetpack()
    {
        isRising = false;
        Flame1.SetActive(false);
        Flame2.SetActive(false);
        //PlatformTransform.GetComponent<Animator>().Play("New State");
        //Platform.transform.SetParent(PlayerTransform);
        yield return new WaitForSeconds(0.1f);

        PlatformTransform.DetachChildren();
        yield return new WaitForSeconds(0f);
    }
}