using JetBrains.Annotations;
using UnityEngine;

public class power : MonoBehaviour
{
    public Clock clock;
    int prevSecond = 0;
    int powerLoseCounter = 0;
    int powerLoseRate = 20;

    public int Power = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clock = clock.GetComponent<Clock>();
       
        
        
    }

    // Update is called once per frame
    void Update()
    {
      
        losePower();
        
    }

    void losePower()
    {
        if (clock.seconds != prevSecond)
        {
            prevSecond = clock.seconds;
            powerLoseCounter++;

            if (powerLoseCounter == powerLoseRate)
            {
                Power--;
                powerLoseCounter = 0;
                Debug.Log(Power);
            }
        }
    }
}
