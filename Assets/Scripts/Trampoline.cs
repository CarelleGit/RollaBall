using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public int force;
    void OnTriggerEnter(Collider other)
    {
        var playerController = other.GetComponent<Rigidbody>();
        if (other.tag == "Player")
        {
            playerController.AddForce(transform.up * force, ForceMode.Impulse);
        }
    }
    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
