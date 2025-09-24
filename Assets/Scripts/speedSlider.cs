using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class speedSlider : MonoBehaviour
{
    public Slider waitSlider;
    public Text waitTimeText;
    int waitTime;

    // Start is called before the first frame update
    void Start()
    {
        waitTime =   Convert.ToInt32(waitSlider.value);
        waitTimeText.text = Convert.ToString(waitTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
