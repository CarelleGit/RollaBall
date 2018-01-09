using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public float rotationSpeed;

    public int scoreAdded;


   

    void Awake()
    {

      
    }

    private void Update()
    {
        transform.Rotate(rotationSpeed, 0, rotationSpeed / 3);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var playerController = other.GetComponent<Controller>();
            if (playerController != null)
            {
                playerController.score += scoreAdded;
                playerController.text.text ="Score: " + playerController.score;
                Destroy(gameObject);
            }
            if (playerController.Health <= 0)
            {
                Destroy(gameObject);
            }
            
        }
    }
}
