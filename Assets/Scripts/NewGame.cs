using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using static SharedData;


public class NewGame : MonoBehaviour
{
    public void Update()
    {
        SharedData._money = 500;
        SharedData._month = 1;
        SharedData.pressure = 10;
        SharedData.emotion = 100;
        SharedData.fitness = 100;
        SharedData.score = 100;
        SharedData.energy = 100;
    }
}
