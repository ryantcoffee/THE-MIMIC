using Unity.VisualScripting;
using UnityEngine;

public class bonniecontroller : MonoBehaviour
{

    public Clock clock;
    public CameraControl cameraControl;
    public DoorControl doorControl;

    public int locationIndex = 0;
    
    public int location = 6;
    int prevTime = 0;
    int timePerChance = 2;

    int jumpscareFailTime = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = clock.GetComponent<Clock>();
        cameraControl = cameraControl.GetComponent<CameraControl>();
        doorControl = doorControl.GetComponent<DoorControl>();
    }
    // Update is called once per frame
    void Update()
    {
        moveTime();
        
    }

    void moveTime()
    {
        if (clock.seconds == prevTime + timePerChance)
        {
            prevTime = clock.seconds;
            
            if (Random.Range(1, 10) == 5)
            {
                Move();
                Debug.Log("Bonnie: " + locationIndex + " " + cameraControl.camLocations[locationIndex]);
            }
           
            
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
                } else
                {
                    locationIndex = 0;
                }
                break;

            case 7:
                if (doorControl.rightDoorClosed == false)
                {
                    jumpscare();
                } else
                {
                    locationIndex = 0;
                }
                break;

            default:
                locationIndex += Random.Range(1, 3);
                break;
        
        }
    }

    void jumpscare()
    {
        Debug.Log("Jumpscare!");
    }
}
