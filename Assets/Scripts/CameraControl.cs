using UnityEngine;
using System;

public class CameraControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public power Power;

    public bool camEnabled = false;
    public event Action disableCamEvent;
    public event Action enableCamEvent;


    //specific camera events
    public event Action cam1event;
    public event Action cam2event;
    public event Action cam3event;
    public event Action cam4event;
    public event Action cam5event;
    public event Action cam6event;
    public event Action cam7event;
    public event Action cam8event;
    
//                               0  1  2  3  4  5  6  7
    public int[] camLocations = {6, 7, 8, 5, 2, 4, 1, 3};

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
    public void camselect1()
    {
        cam1event.Invoke();
    }
    public void camselect2()
    {
        cam2event.Invoke();
    }
    public void camselect3()
    {
        cam3event.Invoke();
    }
    public void camselect4()
    {
        cam4event.Invoke();
    }
    public void camselect5()
    {
        cam5event.Invoke();
    }
    public void camselect6()
    {
        cam6event.Invoke();
    }
    public void camselect7()
    {
        cam7event.Invoke();
    }
    public void camselect8()
    {
        cam8event.Invoke();
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
