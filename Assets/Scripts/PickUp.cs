using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public float rotationSpeed;

    public int scoreAdded;

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
                Destroy(gameObject);
            }
            if (playerController.Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
