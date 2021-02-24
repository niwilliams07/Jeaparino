using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Button100 : MonoBehaviour
{
    public string Question;
    public string Answer;
    public string points;
    public string QuestionType;
    public GameObject pointstxt;
    public GameObject txt;
    public GameObject answertxt;
    public GameObject button;
    public GameObject screen;
    public Animator anim;
    private void Start() 
    {
        txt = GameObject.Find("QuestionText");
        answertxt = GameObject.Find("AnswerText");
        screen = GameObject.Find("Question");
        pointstxt = GameObject.Find("PointsText");
        button = this.gameObject;
        anim = GameObject.Find("Question").GetComponent<Animator>();

    }

    public void firstQuestion()
    {
        txt.GetComponent<Text>().text = Question;
        answertxt.GetComponent<Text>().text = Answer;
        pointstxt.GetComponent<Text>().text = points;
        anim.SetBool("board", false);
        anim.SetBool(QuestionType, true);
        Destroy(transform.GetChild(0).gameObject);
    }

    
}
