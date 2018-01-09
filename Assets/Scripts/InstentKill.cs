using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstentKill : MonoBehaviour
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
                playerController.Health -= 10;
                Destroy(gameObject);
            }
        }
    }
}
