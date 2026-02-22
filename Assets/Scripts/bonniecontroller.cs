using Unity.VisualScripting;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class bonniecontroller : MonoBehaviour
{

    public Clock clock;
    public CameraControl cameraControl;
    public DoorControl doorControl;
    public jumpscareController jumpscareControl;

    public event Action bonnieJumpscare;

    public int locationIndex = 0;
    
    public int location = 6;
    int prevTime = 0;
    int timeSinceJumpscare = 100000;
    int timePerChance = 2;

    int jumpscareFailTime = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = clock.GetComponent<Clock>();
        cameraControl = cameraControl.GetComponent<CameraControl>();
        doorControl = doorControl.GetComponent<DoorControl>();
        jumpscareControl = jumpscareControl.GetComponent<jumpscareController>();
    }
    // Update is called once per frame
    void Update()
    {
        moveTime();
        Debug.Log(timeSinceJumpscare + " " + clock.seconds);
    }

    void moveTime()
    {
        if (clock.seconds == prevTime + timePerChance)
        {
            prevTime = clock.seconds;
            
            if (UnityEngine.Random.Range(1, 10) == 5)
            {
                Move();
                Debug.Log("Bonnie: " + locationIndex + " " + cameraControl.camLocations[locationIndex]);
            }
           
            
        }

        if (clock.seconds == timeSinceJumpscare + 4)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void Move()
    {
        switch (locationIndex)
        {
            case 4:
                locationIndex = 6;
                break;
            case 5:
                locationIndex = 7;
                break;
            case 6:
                if (doorControl.leftDoorClosed == false)
                {
                    jumpscare();
                    locationIndex = 0;
                } else
                {
                    locationIndex = 0;
                }
                break;

            case 7:
                if (doorControl.rightDoorClosed == false)
                {
                    jumpscare();
                    locationIndex = 0;
                } else
                {
                    locationIndex = 0;
                }
                break;

            default:
                locationIndex += UnityEngine.Random.Range(1, 3);
                break;
        
        }
    }

    void jumpscare()
    {
        Debug.Log("Jumpscare!");
        //jumpscareControl.killerAnimtronic = "Bonnie";
        bonnieJumpscare.Invoke();
        timeSinceJumpscare = clock.seconds;


    }
}
