using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        if (gameObject.tag == "Player")
        {
            var playerController = gameObject.GetComponent<Controller>();
            if (playerController.score == 2)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
