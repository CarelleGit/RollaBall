using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour {

    public float rotationSpeed;

    public int AddHealth;

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
                playerController.Health += AddHealth;
                Destroy(gameObject);
            }
            if (playerController.Health >= 30)
            {
                playerController.Health = 30;
                Destroy(gameObject);
            }
            if (playerController.Health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
