using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    [SerializeField] Text _currentTime;

    void Start()
    {
        
    }

    void Update()
    {
        _currentTime.text = GetCurrentTime();
    }
    private string GetCurrentTime()
    {
        return DateTime.Now.ToString(("HH:mm"));
    }
}
