using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotator : MonoBehaviour
{
    public Slider mySlider;
    public float yLimit = 45f;
    void Start()
    {
        mySlider.onValueChanged.AddListener(delegate { RotateMe(); });
    }

    public void RotateMe()
    {
        transform.localEulerAngles = new Vector3(0, mySlider.value * yLimit, 0);
    }
     void Update()
    {
        
    }
    //  public bool rotateObject = true;
    //
    //  private void Update()
    //  {
    //      transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    //  }
} //
