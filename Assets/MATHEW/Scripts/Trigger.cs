using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public GameObject UiObject;
    
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            UiObject.SetActive(true);
            Debug.Log(other.name);
        }
        Debug.Log("ENTER");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerExit(Collider other)
    {
        UiObject.SetActive(false);
        
        Debug.Log("EXIT");
    }
}
