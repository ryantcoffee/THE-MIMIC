using UnityEngine;
using System;

public class CameraControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool camEnabled = false;
    public event Action disableCamEvent;
    public event Action enableCamEvent;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onLeftButtonClick()
    {
        if (camEnabled == false)
        {
            Debug.Log("Camera Enabled");
            camEnabled = true;
            enableCamEvent.Invoke();
        }
        else
        {
            Debug.Log("Camera Disabled");
            camEnabled = false;
            disableCamEvent.Invoke();
        }
    }
}
