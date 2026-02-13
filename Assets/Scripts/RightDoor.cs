using System.Xml.Serialization;
using UnityEngine;

public class RightDoor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    [SerializeField] private DoorControl Sender;
    
    private SpriteRenderer rightDoorSprite;
    
    
    void Start()
    {
        Sender.closeRightDoorEvent += closeRightDoor;
        Sender.openRightDoorEvent += openRightDoor;
        rightDoorSprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void closeRightDoor()
    {
        rightDoorSprite.enabled = true;
    }

    void openRightDoor()
    {
        rightDoorSprite.enabled = false; 
    }
}
