using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Coin : MonoBehaviour
{
    private Moveme playerJumpScript;
    [SerializeField] private Text coincounter;
    private int coincollected = 0;
    // Start is called before the first frame update
    void Start()
    {
        playerJumpScript = GetComponent<Moveme>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            coincollected++;
            if (coincollected >= 4)
            {
                SceneManager.LoadScene(4);

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        coincounter.text = ("" + coincollected);


    }
}
