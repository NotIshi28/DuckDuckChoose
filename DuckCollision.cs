using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckCollision : MonoBehaviour
{
    public GameObject ogDuck;
    public GameObject duckTrampled;
    public GameObject car;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (ogDuck.GetComponent<Collider>().bounds.Intersects(car.GetComponent<Collider>().bounds))
        {
            ogDuck.SetActive(false);
            duckTrampled.SetActive(true);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            ogDuck.SetActive(false);
            duckTrampled.SetActive(true);
            
        }
    }
}
