using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    public float moveStrenght;
    public float jumpStrenght;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * jumpStrenght);
        }
        if(Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * moveStrenght);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.left * moveStrenght);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.back * moveStrenght);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.right * moveStrenght);
        }
    }
}
