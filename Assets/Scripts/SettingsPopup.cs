﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsPopup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private Slider speedSlider;
    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void OnSubmitName(string name)
    {
        Debug.Log(name);
    }
    public void OnSpeedValue(float speed)
    {
        PlayerPrefs.SetFloat("speed", speed);
        Messenger<float>.Broadcast(GameEvent.SPEED_CHANGED, speed);
        //Debug.Log("Speed: " + speed);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
