using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FreddyController : MonoBehaviour
{

    public Clock clock;
    public CameraControl cameraControl;
    public DoorControl doorControl;
    public jumpscareController jumpscareControl;

    public int locationIndex = 0;
    
    public int location = 6;
    int prevTime = 0;
    int timePerChance = 7;

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
        // if (clock.seconds == 5)
        // {
        //     jumpscare();
        // }
        
    }

    void moveTime()
    {
        if (clock.seconds == prevTime + timePerChance)
        {
            prevTime = clock.seconds;
            
            if (Random.Range(1, 2) == 1)
            {
                Move();
                Debug.Log("Freddy: " + locationIndex + " " + cameraControl.camLocations[locationIndex]);
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
        jumpscareControl.killerAnimtronic = "Freddy";
        SceneManager.LoadScene("Jumpscare");
    }
}

