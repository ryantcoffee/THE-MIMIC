using UnityEngine;
using UnityEngine.UI;

public class rightbutton : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Image image;
    [SerializeField] private DoorControl Sender;
    void Start()
    {
        Sender.closeRightDoorEvent += greenButton;
        Sender.openRightDoorEvent += redButton;
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void greenButton()
    {
        image.color = Color.green;
    }

    void redButton()
    {
        image.color = Color.red;
    }
}
