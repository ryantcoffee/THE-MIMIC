using System.Xml.Serialization;
using UnityEngine;

public class LeftDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    private SpriteRenderer leftDoorSprite;
    [SerializeField] private DoorControl Sender; 
    
    void Start()
    {
        Sender.closeLeftDoorEvent += closeLeftDoor;
        Sender.openLeftDoorEvent += openLeftDoor;
        leftDoorSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeLeftDoor()
    {
        leftDoorSprite.enabled = true;
    }

    void openLeftDoor()
    {
        leftDoorSprite.enabled = false; 
    }
}
