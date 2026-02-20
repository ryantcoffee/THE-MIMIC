using UnityEngine;

public class chica : MonoBehaviour
{

public chicacontroller chicacontroller;
public CameraControl cameracontrol;
public SpriteRenderer spriteRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chicacontroller = chicacontroller.GetComponent<chicacontroller>();
        cameracontrol = cameracontrol.GetComponent<CameraControl>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(chicacontroller.locationIndex == 0) //index 0 corresponds with cam 6
        {
            cam6();
        }else if(chicacontroller.locationIndex == 1)
        {
            cam7();
        }else if(chicacontroller.locationIndex == 2)
        {
            cam8();
        }else if(chicacontroller.locationIndex == 3)
        {
            cam5();
        }else if(chicacontroller.locationIndex == 4)
        {
            cam2();
        }else if(chicacontroller.locationIndex == 5)
        {
            cam4();
        }else if(chicacontroller.locationIndex == 6)
        {
            cam1();
        }else if(chicacontroller.locationIndex == 7)
        {
            cam3();
        }
    }

    void cam1()
    {
        transform.position = new Vector2(4.23f, -1.18f);
        transform.localScale = new Vector2(3.074149f, 3.425946f);

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
        transform.position = new Vector2(2.39f, 2.01f);
        transform.localScale = new Vector2(1.010119f, 1.215424f);

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
        transform.position = new Vector2(-6.98f, -2.43f);
        transform.localScale = new Vector2(3.340009f, 4.01886f);

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
        transform.position = new Vector2(-3.99f, -0.88f);
        transform.localScale = new Vector2(2.643791f, 3.181137f);

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
        transform.position = new Vector2(-7.07f, -1.42f);
        transform.localScale = new Vector2(1.756065f, 2.112982f);

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
        transform.position = new Vector2(3.36f, -1.07f);
        transform.localScale = new Vector2(2.528871f, 3.04286f);

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
        transform.position = new Vector2(3.5f, 0.59f);
        transform.localScale = new Vector2(2.050926f, 2.467774f);

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
        transform.position = new Vector2(3.98f, 2.31f);
        transform.localScale = new Vector2(1.474179f, 1.773803f);

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
