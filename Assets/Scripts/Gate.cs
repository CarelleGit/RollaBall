using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    public GameObject gate;

    public int needed;
    // Use this for initialization
    void Start()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var playerController = collision.gameObject.GetComponent<Controller>();
            if (playerController.score >= needed)
            {
                gate.gameObject.SetActive(false);
                playerController.score -= needed;
                playerController.text.text = "Score: " + playerController.score;
            }
        }
    }

    void Update()
    {
       
    }
}
