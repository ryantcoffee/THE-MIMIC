using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class power : MonoBehaviour
{
    public Clock clock;
    public DoorControl doorControl;
    public CameraControl cameraControl;


    int prevSecond = 0;
    int powerLossOverTime = 1;
    int counterBeforePowerLoss = 0;
    int powerLossRate = 20;

    int powerLossLeftDoor = 0;
    int powerLossRightDoor = 0;
    int powerLossDoors = 0;
    int powerLossCamera = 0;
    int powerLossCounterIncreaseTotal = 0;

    public float Power = 100;
    public float maxPower = 100;
    public float powerPercent = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = clock.GetComponent<Clock>();
        doorControl = doorControl.GetComponent<DoorControl>();
        cameraControl = cameraControl.GetComponent<CameraControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Power <= 0)
        {
            Power = 0;
        } else
        {
            losePower();
        }

        doorPowerLoss();
        cameraPowerLoss();
        powerPercent = (Power / maxPower) * 100;

        Debug.Log(powerLossCounterIncreaseTotal);
    }

    void losePower()
    {
        powerLossCounterIncreaseTotal = powerLossOverTime + powerLossDoors + powerLossCamera;

        if (clock.seconds != prevSecond)
        {
            prevSecond = clock.seconds;
            counterBeforePowerLoss  += powerLossCounterIncreaseTotal;

            if (counterBeforePowerLoss >= powerLossRate)
            {
                Power--;
                counterBeforePowerLoss = 0;
            }
        }
    }

    void doorPowerLoss()
    {
        if (doorControl.leftDoorClosed)
        {
            powerLossLeftDoor = 7;
        } else
        {
            powerLossLeftDoor = 0;
        }
        if (doorControl.rightDoorClosed)
        {
            powerLossRightDoor = 7;
        } else
        {
            powerLossRightDoor = 0;
        }

        powerLossDoors = powerLossLeftDoor + powerLossRightDoor;
    }

    void cameraPowerLoss() {
        if (cameraControl.camEnabled)
        {
            powerLossCamera = 2;
        } else
        {
            powerLossCamera = 0;
        }
    }
}
