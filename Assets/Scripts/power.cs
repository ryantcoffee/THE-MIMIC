// using JetBrains.Annotations;
// using UnityEngine;

// public class power : MonoBehaviour
// {
//     public Clock clock;
//     int second = 0;
//     int prevSecond = 0;
//     int powerLoseCounter = 0;
//     int powerLoseRate = 20;

//     int Power = 100;

//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
//         clock = clock.GetComponent<Clock>();
//         second = clock.seconds;
        
        
//     }

//     // Update is called once per frame
//     void Update()
//     {
//         prevSecond = clock.seconds;
//         losePower();
//     }

//     void losePower()
//     {
//         if (second != prevSecond)
//         {
//             prevSecond = clock.seconds;
//             powerLoseCounter++;
//             second++;

//             if (powerLoseCounter == powerLoseRate)
//             {
//                 Power--;
//                 powerLoseCounter = 0;
//                 Debug.Log(Power);
//             }
//         }
//     }
// }
