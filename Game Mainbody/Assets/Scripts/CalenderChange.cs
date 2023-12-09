using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//引用UI库

public class CalenderChange : MonoBehaviour
{

    public Text textshow;

    int month = 1;


    void Update()
    {
        textshow.text = (" "+month);
    }

    public void grade()
    {
        if(true)//当本月安排结束
            month++;
    }
}
