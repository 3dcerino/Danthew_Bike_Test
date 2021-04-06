using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementZ : MonoBehaviour
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
        MyInput();
    }

    void MoveObject()
    {
        //transform.Translate(speed * Vector3.right * Time.deltaTime);
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
    void MyInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speed = 0;
        }
    }
}
