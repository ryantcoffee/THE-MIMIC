using UnityEngine;

public class freddy : MonoBehaviour
{

public FreddyController freddycontroller;
public CameraControl cameracontrol;
public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        freddycontroller = freddycontroller.GetComponent<FreddyController>();
        cameracontrol = cameracontrol.GetComponent<CameraControl>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(freddycontroller.locationIndex == 0) //index 0 corresponds with cam 6
        {
            cam6();
        }else if(freddycontroller.locationIndex == 1)
        {
            cam7();
        }else if(freddycontroller.locationIndex == 2)
        {
            cam8();
        }else if(freddycontroller.locationIndex == 3)
        {
            cam5();
        }else if(freddycontroller.locationIndex == 4)
        {
            cam2();
        }else if(freddycontroller.locationIndex == 5)
        {
            cam4();
        }else if(freddycontroller.locationIndex == 6)
        {
            cam1();
        }else if(freddycontroller.locationIndex == 7)
        {
            cam3();
        }
    }

    void cam1()
    {
        transform.position = new Vector2(-2.27f, -0.32f);
        transform.localScale = new Vector2(0.6878375f, 0.6878375f);

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
        transform.position = new Vector2(-6.46f, -12.69f);
        transform.localScale = new Vector2(1.771027f, 1.771027f);

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
        transform.position = new Vector2(1.81f, -3.59f);
        transform.localScale = new Vector2(1.045757f, 1.045757f);

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
        transform.position = new Vector2(7.06f, -4.13f);
        transform.localScale = new Vector2(1.467428f, 1.467428f);

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
        transform.position = new Vector2(1.7f, -0.73f);
        transform.localScale = new Vector2(0.4328232f, 0.4328232f);

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
        transform.position = new Vector2(-0.5f, -1);
        transform.localScale = new Vector2(0.6878375f, 0.6878375f);

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
        transform.position = new Vector2(2.08f, -6.43f);
        transform.localScale = new Vector2(1.043594f, 1.043594f);

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
        transform.position = new Vector2(-3.32f, -2.27f);
        transform.localScale = new Vector2(0.7487502f, 0.7487502f);

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
