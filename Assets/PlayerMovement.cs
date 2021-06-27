using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The game has start");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }
        else if (Input.GetKey("up"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 5);
        }
        else if (Input.GetKey("down"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -5);
        }
        else if (Input.GetKey("right"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(5, 0, 0);
        }
        else if (Input.GetKey("left"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-5, 0, 0);
        }
    }
}
