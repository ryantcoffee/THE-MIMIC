using System;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onLeftButtonClick()
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

    public void onRightButtonClick()
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
