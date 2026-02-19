using UnityEngine;

public class cam6 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private SpriteRenderer camsprite;
    [SerializeField] private CameraControl Sender;
    void Start()
    {
        Sender.cam1event += closecam;
        Sender.cam2event += closecam;
        Sender.cam3event += closecam;
        Sender.cam4event += closecam;
        Sender.cam5event += closecam;
        Sender.cam6event += opencam;
        Sender.cam7event += closecam;
        Sender.cam8event += closecam;
        camsprite = GetComponent<SpriteRenderer>();
        camsprite.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void opencam()
    {
        camsprite.enabled = true;
    }

    void closecam()
    {
        camsprite.enabled = false;
    }
}
