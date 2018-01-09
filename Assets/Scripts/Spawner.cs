using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pickUp;
    public float spawnI;
    public float rang;
    float timer;
	// Use this for initialization
	void Start ()
    {
        timer = 0;
	}
	
    void PickUp()
    {
        GameObject spawnpickup = Instantiate(pickUp);
        float ranX = Random.Range(-rang, rang);
        float ranz = Random.Range(-rang, rang);
        float ranZ;
        spawnpickup.transform.position = transform.position + new Vector3(ranX, 0, ranz);
    }

	// Update is called once per frame
	void Update ()
    {
        timer -= Time.deltaTime;
        if(timer <0)
        {
            PickUp();
            timer = spawnI;
        }
       

	}
}
