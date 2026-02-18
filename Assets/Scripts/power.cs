using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class power : MonoBehaviour
{
    public Clock clock;
    public DoorControl doorControl;
    int prevSecond = 0;
    int powerLoseCounterIncrease = 1;
    int powerLoseCounter = 0;
    int powerLoseRate = 20;

    int powerLossLeftDoor = 0;
    int powerLossRightDoor = 0;
    int powerLossDoors = 0;

    public float Power = 100;
    public float maxPower = 100;
    public float powerPercent = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = clock.GetComponent<Clock>();
        doorControl = doorControl.GetComponent<DoorControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        losePower();
        doorPowerLoss();
        powerPercent = (Power / maxPower) * 100;
    }

    void losePower()
    {
        if (clock.seconds != prevSecond)
        {
            prevSecond = clock.seconds;
            powerLoseCounter  += (powerLoseCounterIncrease + powerLossDoors);

            if (powerLoseCounter >= powerLoseRate)
            {
                Power--;
                powerLoseCounter = 0;
            }
        }
    }

    void doorPowerLoss()
    {
        if (doorControl.leftDoorClosed)
        {
            powerLossLeftDoor = 3;
        } else
        {
            powerLossLeftDoor = 0;
        }
        if (doorControl.rightDoorClosed)
        {
            powerLossRightDoor = 3;
        } else
        {
            powerLossRightDoor = 0;
        }

        powerLossDoors = powerLossLeftDoor + powerLossRightDoor;
    }
}
