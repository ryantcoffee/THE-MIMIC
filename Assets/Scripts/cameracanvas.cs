using UnityEngine;

public class cameracanvas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private Canvas cameraCanvas;
    [SerializeField] private CameraControl Sender;
    void Start()
    {
        Sender.enableCamEvent += enableCam;
        Sender.disableCamEvent += disableCam;
        cameraCanvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enableCam()
    {
        cameraCanvas.enabled = true;
    }

    void disableCam()
    {
        cameraCanvas.enabled = false;
    }
}
