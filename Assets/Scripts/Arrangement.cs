using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;
using static SharedData;

public class Arrangement : MonoBehaviour
{
    public Button a1_Button;
    public Button a2_Button;
    public Button a3_Button;
    public Button a4_Button;

    public TextMeshProUGUI money_Text;
    public TextMeshProUGUI month_Text;
    public TextMeshProUGUI pressure_Text;
    public TextMeshProUGUI emotion_Text;
    public TextMeshProUGUI fitness_Text;
    public TextMeshProUGUI score_Text;
    public TextMeshProUGUI energy_Text;

    public void Start()
    {
        a1_Button.onClick.AddListener(ButtonClick1);
        a2_Button.onClick.AddListener(ButtonClick2);
        a3_Button.onClick.AddListener(ButtonClick3);
        a4_Button.onClick.AddListener(ButtonClick4);
    }

    public void ButtonClick1()
    {
        SharedData.score = SharedData.score + 5;
        SharedData.pressure = SharedData.pressure + 2;
        SharedData.emotion = SharedData.emotion - 3;
        SharedData.energy = SharedData.energy - 1;
        SharedData._month = SharedData._month + 1;
        SharedData.pressure = SharedData.pressure + 5;
        SharedData.emotion = SharedData.emotion - 5;
        SharedData.fitness = SharedData.fitness + 5;
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        score_Text.text = SharedData.score.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
        energy_Text.text = String.Format("{0}/100", SharedData.energy);
        a1_Button.gameObject.SetActive(false);
    }

    public void ButtonClick2()
    {
        SharedData.pressure = SharedData.pressure - 3;
        SharedData.emotion = SharedData.emotion + 3;
        SharedData.energy = SharedData.energy - 1;
        SharedData.fitness = SharedData.fitness + 3;
        SharedData._month = SharedData._month + 1;
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        score_Text.text = SharedData.score.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
        energy_Text.text = String.Format("{0}/100", SharedData.energy);
        a2_Button.gameObject.SetActive(false);
    }

    public void ButtonClick3()
    {
        SharedData.pressure = SharedData.pressure - 5;
        SharedData.emotion = SharedData.emotion + 5;
        SharedData.energy = SharedData.energy - 1;
        SharedData._month = SharedData._month + 1;
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        score_Text.text = SharedData.score.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
        energy_Text.text = String.Format("{0}/100", SharedData.energy);
        a3_Button.gameObject.SetActive(false);
    }

    public void ButtonClick4()
    {
        SharedData.pressure = SharedData.pressure - 3;
        SharedData.emotion = SharedData.emotion - 2;
        SharedData.energy = SharedData.energy - 1;
        SharedData._month = SharedData._month + 1;
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        score_Text.text = SharedData.score.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
        energy_Text.text = String.Format("{0}/100", SharedData.energy);
        a4_Button.gameObject.SetActive(false);
    }
}
