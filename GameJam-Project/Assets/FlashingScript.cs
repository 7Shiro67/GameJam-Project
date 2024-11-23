using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlashingScript : MonoBehaviour
{
    public float transparency = 1f;
    public Text FlashingText;
    private Color originalColor;
    private Color flashColor;
    public float flashSpeed = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        FlashingText = GetComponent<Text>();
        originalColor = FlashingText.color;
        flashColor = originalColor;
    }

    // Update is called once per frame
    void Update()
    {
        flashColor.a = Mathf.PingPong(Time.time * flashSpeed, 1) * transparency;
        FlashingText.color = flashColor;
    }
}