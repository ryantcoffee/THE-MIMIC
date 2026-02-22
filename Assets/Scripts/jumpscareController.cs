using UnityEngine;

public class jumpscareController : MonoBehaviour
{
    public static jumpscareController Instance;
    public string killerAnimtronic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void Awake()
    // {
    //     if (Instance == null)
    //     {
    //         Instance = this;
    //         DontDestroyOnLoad(gameObject);
    //     }
    //     else
    //     {
    //         Destroy(gameObject); // Destroys duplicate instances if a new scene tries to create one
    //     }
    // }
}

