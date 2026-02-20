using UnityEngine;

public class bonnie : MonoBehaviour
{

public bonniecontroller bonniecontroller;
public CameraControl cameracontrol;
public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bonniecontroller = bonniecontroller.GetComponent<bonniecontroller>();
        cameracontrol = cameracontrol.GetComponent<CameraControl>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(bonniecontroller.locationIndex == 0) //index 0 corresponds with cam 6
        {
            cam6();
        }else if(bonniecontroller.locationIndex == 1)
        {
            cam7();
        }else if(bonniecontroller.locationIndex == 2)
        {
            cam8();
        }else if(bonniecontroller.locationIndex == 3)
        {
            cam5();
        }else if(bonniecontroller.locationIndex == 4)
        {
            cam2();
        }else if(bonniecontroller.locationIndex == 5)
        {
            cam4();
        }else if(bonniecontroller.locationIndex == 6)
        {
            cam1();
        }else if(bonniecontroller.locationIndex == 7)
        {
            cam3();
        }
    }

    void cam1()
    {
        transform.position = new Vector2(2.5f, -0.81f);
        transform.localScale = new Vector2(3.079847f, 3.710673f);

        if(cameracontrol.currentCam == 1)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    void cam2()
    {
        transform.position = new Vector2(-0.09f, -0.8f);
        transform.localScale = new Vector2(2.720623f, 3.277871f);

        if(cameracontrol.currentCam == 2)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    void cam3()
    {
        transform.position = new Vector2(-0.6f, -2.46f);
        transform.localScale = new Vector2(3.941639f, 4.74898f);

        if(cameracontrol.currentCam == 3)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    void cam4()
    {
        transform.position = new Vector2(0.24f, -2.86f);
        transform.localScale = new Vector2(4.917589f, 5.924827f);

        if(cameracontrol.currentCam == 4)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    void cam5()
    {
        transform.position = new Vector2(-3.34f, -5.87f);
        transform.localScale = new Vector2(4.408475f, 5.311434f);

        if(cameracontrol.currentCam == 5)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }
    void cam6()
    {
        transform.position = new Vector2(-4.31f, -0.82f);
        transform.localScale = new Vector2(3.032902f, 3.654111f);

        if(cameracontrol.currentCam == 6)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }

    }

    void cam7()
    {
        transform.position = new Vector2(1.52f, 0.28f);
        transform.localScale = new Vector2(2.521814f, 3.03834f);

        if(cameracontrol.currentCam == 7)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }

    void cam8()
    {
        transform.position = new Vector2(1.08f, -0.29f);
        transform.localScale = new Vector2(2.825659f, 3.40442f);

        if(cameracontrol.currentCam == 8)
        {
            spriteRenderer.enabled = true;
        }
        else
        {
            spriteRenderer.enabled = false;
        }
    }


}
