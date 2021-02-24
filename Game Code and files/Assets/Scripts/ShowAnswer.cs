using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowAnswer : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GameObject.Find("Question").GetComponent<Animator>();
    }

    public void answerShow()
    {
        if (anim.GetBool("Ques"))
        {
            anim.SetBool("Ques", false);
            anim.SetBool("Answer", true);
        }
        else
        {
            anim.SetBool("Answer", false);
            anim.SetBool("board", true);
        }
        
    }
}
