using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsIncrease : MonoBehaviour
{
    public Text PointsTxt;
    public Text ScoreTxt;
    public float animationTime = 1f;
    public float desiredNumber, initialNumber, currentNumber;
    public AudioSource adding;
    // Start is called before the first frame update    
    void Start()
    {
        PointsTxt = GameObject.Find("PointsText").GetComponent<Text>();
        ScoreTxt = this.gameObject.GetComponent<Text>();
        adding = GameObject.Find("Points Sound").GetComponent<AudioSource>();
    }

    /*public void SetNumber()
    {
        initialNumber = currentNumber;
        desiredNumber = int.Parse(PointsTxt.text);
    }*/

    public void AddToNumber()
    {
        initialNumber = currentNumber;
        desiredNumber += int.Parse(PointsTxt.text);
        adding.Play();
    }
    public void SubtractFromNumber()
    {
        initialNumber = currentNumber;
        desiredNumber -= int.Parse(PointsTxt.text);
        adding.Play();
    }

    // Update is called once per frame
    public void Update()
    {
        if (currentNumber != desiredNumber)
        {
            if (initialNumber < desiredNumber)
            {
                currentNumber += ((Time.deltaTime/animationTime) * (desiredNumber - initialNumber));
                if(currentNumber >= desiredNumber)
                {
                    currentNumber = desiredNumber;
                }
            }
            else
            {
                currentNumber -= (Time.deltaTime/animationTime) * (initialNumber - desiredNumber);
                if (currentNumber <= desiredNumber)
                {
                    currentNumber = desiredNumber;
                }
            }
            ScoreTxt.text = Mathf.Round(currentNumber).ToString();
        }
    }
}
