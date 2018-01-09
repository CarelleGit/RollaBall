using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private bool grounded = true;
    public int score;
    public Slider healthBar;
    Vector3 startPos;
    GameObject bad;
    public int Health = 30;
    public float respawnTime;
    void Start()
    {
       // respawnTimer = respawnTime;
        startPos = transform.position;
        score = 0;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = false;
        }
    }



    void Update ()

    {
        healthBar.value = Health;
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontal, 0, vertical);
        Vector3 desiredVelocity = move * speed * Time.deltaTime;
        rb.velocity = new Vector3(desiredVelocity.x, rb.velocity.y, desiredVelocity.z);
        if (grounded == false)
        {
            transform.position = startPos;
            score -= 5;
            Health -= 2;
        }
        if (Health <= 0)
        {
            transform.position = startPos;
            score -= 10;
            Health = 30;
        }
    }
}
