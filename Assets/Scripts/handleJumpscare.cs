using Unity.VisualScripting;
using UnityEngine;

public class handleJumpscare : MonoBehaviour
{
    string killerAnimtronic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        killerAnimtronic = jumpscareController.Instance.killerAnimtronic;
        Debug.Log(killerAnimtronic);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void jumpscare(){
        if (killerAnimtronic == "Freddy")
        {
            // Freddy jumpscare code
        }
        else if (killerAnimtronic == "Chica")
        {
            // Chica jumpscare code
        }
        else
        {
            // Bonnie jumpscare code
        }
    }
}
