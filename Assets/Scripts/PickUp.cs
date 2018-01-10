using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUp : MonoBehaviour
{
    public float rotationSpeed;
    public int scoreAdded;
    public int Negitive;




    void Awake()
    {
        Negitive += scoreAdded;
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
                if (playerController.score >= 0)
                {
                    playerController.score += scoreAdded;
                }
                else if (playerController.score <= -1)
                {
                    playerController.score += Negitive;
                }
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
