using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dcoin : MonoBehaviour
{
    private Anotha playerJumpScript;
    [SerializeField] private Text coincounter;
    private int coincollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpScript = GetComponent<Anotha>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            coincollected++;
            if (coincollected >= 4)
            {
                SceneManager.LoadScene(5);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        coincounter.text = ("" + coincollected);


    }
}