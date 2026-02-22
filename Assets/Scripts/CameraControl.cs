using UnityEngine;
using System;

public class CameraControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public power Power;

    [SerializeField] public FreddyController freddy;
    [SerializeField] public bonniecontroller bonnie;
    [SerializeField] public chicacontroller chica;

    public bool camEnabled = false;
    public int currentCam = 6;
    public event Action disableCamEvent;
    public event Action enableCamEvent;

    public AudioSource toggleCam;
    public AudioSource switchCam;


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
        freddy.freddyJumpscare += Jumpscare;
        bonnie.bonnieJumpscare += Jumpscare;
        chica.chicaJumpscare += Jumpscare;
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
            toggleCam.Play();
        }
        else
        {
            Debug.Log("Camera Disabled");
            camEnabled = false;
            disableCamEvent.Invoke();
            toggleCam.Play();
        }

        }
        
    }

    public void Jumpscare()
    {
        disableCamEvent.Invoke();
    }
    public void camselect1()
    {
        cam1event.Invoke();
        currentCam = 1;
        switchCam.Play();
    }
    public void camselect2()
    {
        cam2event.Invoke();
        currentCam = 2;
        switchCam.Play();
    }
    public void camselect3()
    {
        cam3event.Invoke();
        currentCam = 3;
        switchCam.Play();
    }
    public void camselect4()
    {
        cam4event.Invoke();
        currentCam = 4;
        switchCam.Play();
    }
    public void camselect5()
    {
        cam5event.Invoke();
        currentCam = 5;
        switchCam.Play();
    }
    public void camselect6()
    {
        cam6event.Invoke();
        currentCam = 6;
        switchCam.Play();
    }
    public void camselect7()
    {
        cam7event.Invoke();
        currentCam = 7;
        switchCam.Play();
    }
    public void camselect8()
    {
        cam8event.Invoke();
        currentCam = 8;
        switchCam.Play();
    }


    void checkCameraPower()
    {
        if (Power.Power <= 0)
        {
            if (camEnabled == true)
            {
                camEnabled = false;
                disableCamEvent.Invoke();
                toggleCam.Play();
            }
        }
    }

}
