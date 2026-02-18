using UnityEngine;

public class officecanvas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Canvas officeCanvas;
    [SerializeField] private CameraControl Sender;
    void Start()
    {
        Sender.enableCamEvent += enableCam;
        Sender.disableCamEvent += disableCam;
        officeCanvas = GetComponent<Canvas>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableCam()
    {
        officeCanvas.enabled = false;
        gameObject.SetActive(false);
    }

    void disableCam()
    {
        officeCanvas.enabled = true;
        gameObject.SetActive(true);
    }
}
