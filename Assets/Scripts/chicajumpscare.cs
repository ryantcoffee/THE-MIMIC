using UnityEngine;
using System.Xml.Serialization;
using TMPro;

public class chicajumpscare : MonoBehaviour
{

    public SpriteRenderer spriteRenderer;
    [SerializeField] public chicacontroller chica;
    public AudioSource audioSource;

    public float speed = 80f;
    public float targetY = -1f;
    
    public bool jumpscareTriggered = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chica.chicaJumpscare += chicaDeath;
        spriteRenderer = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpscareTriggered == true && transform.position.y < targetY)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }


    }

    void chicaDeath()
    {
        jumpscareTriggered = true;
        spriteRenderer.enabled = true;
        audioSource.Play();
    }

    
}
