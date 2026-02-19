using System;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    public power Power;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool leftDoorClosed = false;
    public bool rightDoorClosed = false;
    
    //Initialize Actions
    public event Action closeLeftDoorEvent;
    public event Action openLeftDoorEvent;
    public event Action closeRightDoorEvent;
    public event Action openRightDoorEvent;

    void Start()
    {
        Power = Power.GetComponent<power>();
    }

    // Update is called once per frame
    void Update()
    {
        checkDoorPower();
    }

    public void onLeftButtonClick()
    {
        if (Power.Power > 0)
        {
            if (leftDoorClosed == false)
        {
            Debug.Log("Left Door Closed!");
            leftDoorClosed = true;
            closeLeftDoorEvent.Invoke();
        }
        else
        {
            Debug.Log("Left Door Opened!");
            leftDoorClosed = false;
            openLeftDoorEvent.Invoke();
        }

        }
        
    }

    public void onRightButtonClick()
    {
        if (Power.Power > 0)
        {
            if (rightDoorClosed == false)
        {
            Debug.Log("Right Door Closed!");
            rightDoorClosed = true;
            closeRightDoorEvent.Invoke();
        }
        else
        {
            Debug.Log("Right Door Opened!");
            rightDoorClosed = false;
            openRightDoorEvent.Invoke();
        }
        
        }
        
    }

    void checkDoorPower()
    {
        if (Power.Power <= 0)
        {
            if (leftDoorClosed == true)
            {
                leftDoorClosed = false;
                openLeftDoorEvent.Invoke();
            }
            if (rightDoorClosed == true)
            {
                rightDoorClosed = false;
                openRightDoorEvent.Invoke();
            }
        }
    }
}
