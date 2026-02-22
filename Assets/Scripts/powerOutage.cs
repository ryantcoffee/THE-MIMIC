using UnityEngine;

public class powerOutage : MonoBehaviour
{


    public power Power;
    public SpriteRenderer spriteRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Power = Power.GetComponent<power>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Power.Power == 0)
        {
            spriteRenderer.enabled = true;
        }
    }
}
