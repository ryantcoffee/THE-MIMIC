using UnityEngine;
using System;

public class CameraControl : MonoBehaviour
{
    public power Power;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool camEnabled = false;
    public event Action disableCamEvent;
    public event Action enableCamEvent;

    void Start()
    {
        Power = Power.GetComponent<power>();
    }

    // Update is called once per frame
    void Update()
    {
        checkCameraPower();
    }

    public void onLeftButtonClick()
    {
        if (Power.Power > 0)
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

    void checkCameraPower()
    {
        if (Power.Power <= 0)
        {
            if (camEnabled == true)
            {
                camEnabled = false;
                disableCamEvent.Invoke();
            }
        }
    }
}
