using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool isRunning;
    public float timeRemaining;
    public Text clock;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            timeRemaining = timeRemaining - Time.deltaTime;
            if(timeRemaining <= 0)
            {
                timeRemaining = 0;
                isRunning = false;
                clock.color = new Color(1,0,0,1);
            }
            clock.text = (Mathf.FloorToInt(timeRemaining/60)) + ":" + Mathf.FloorToInt(timeRemaining % 60);
        }
    }

    public void TimmerStart()
    {
        isRunning = !isRunning;
    }
}
