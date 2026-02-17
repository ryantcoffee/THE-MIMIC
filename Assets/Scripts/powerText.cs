using TMPro;
using UnityEngine;

public class powerText : MonoBehaviour
{
    private TextMeshProUGUI PowerText;
    public power power;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = power.GetComponent<power>();
        PowerText = GetComponent<TextMeshProUGUI>();
        
    }

    // Update is called once per frame
    void Update()
    {
        PowerText.text = power.Power.ToString() + "%";
        
    }
}
