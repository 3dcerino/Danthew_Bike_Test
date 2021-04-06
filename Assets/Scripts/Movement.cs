using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    public float speed = 2.5f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //
        MoveObject();
    }

    void MoveObject()
    {
        //transform.Translate(speed * Vector3.right * Time.deltaTime);
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    //This function is called when the Space key is pressed:
    void OnStopMoving()
    {
        //Stop the pieces movement by setting speed to 0
        speed = 0;
        Debug.Log("Stop");

    }

    void OnStop()
    {
        Debug.Log("Test");
    }
}
