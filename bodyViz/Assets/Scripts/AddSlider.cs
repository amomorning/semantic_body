﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddSlider : MonoBehaviour
{
    public Slider sliderInstance;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    public void textUpdate(float value)
    {
        if (text == null)
        {
            text = GetComponent<Text>();
        }
        if (text == null)
        {
            Debug.LogError("why ???");
        }
        text.text = Mathf.RoundToInt(value * 100) + "cm";
    }
}
