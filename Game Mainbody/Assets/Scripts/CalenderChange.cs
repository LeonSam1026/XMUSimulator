using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//����UI��

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
        if(true)//�����°��Ž���
            month++;
    }
}
