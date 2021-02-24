using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPoints : MonoBehaviour
{
    public GameObject pointstxt;
    public Text txt;
    void Start()
    {
        pointstxt = GameObject.Find("PointsText");
    }

    public void Set()
    {
        pointstxt.GetComponent<Text>().text = txt.text;
    }
}
