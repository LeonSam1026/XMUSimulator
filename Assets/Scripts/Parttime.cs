using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class SharedData : MonoBehaviour
{
    public static int _money = 500;
    public static int _month = 1;
    public static int pressure = 10;
    public static int emotion = 100;
    public static int fitness = 100;
    public static int score = 100;
    public static int energy = 10;

}

public class Parttime : MonoBehaviour
{
    public int _money = 500;
    public int _month = 1;
    public int pressure = 10;
    public int emotion = 100;
    public int fitness = 100;
    public int score = 100;
    public int energy = 10;

    public Button m1_Button;
    public Button m2_Button;
    public Button m3_Button;
    public Button m4_Button;

    public TextMeshProUGUI money_Text;
    public TextMeshProUGUI month_Text;
    public TextMeshProUGUI pressure_Text;
    public TextMeshProUGUI emotion_Text;
    public TextMeshProUGUI fitness_Text;
    public TextMeshProUGUI score_Text;
    public TextMeshProUGUI energy_Text;

    public GameObject m_WholePanel;
    public Animator m_WholePanelAnimator;


    public void Start()
    {
        m1_Button.onClick.AddListener(NextOnClick1);
        m2_Button.onClick.AddListener(NextOnClick2);
        m3_Button.onClick.AddListener(NextOnClick3);
        m4_Button.onClick.AddListener(NextOnClick4);
    }

    public void NextOnClick1()
    {
        m1_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥1
        m_WholePanelAnimator.Play("DataMenu_hide"); // ²¥·Å Hide ¶¯»­
        SharedData._money = SharedData._money + 300;
        SharedData._month = SharedData._month + 2;
        SharedData.pressure = SharedData.pressure + 5;
        SharedData.emotion = SharedData.emotion - 5;
        SharedData.fitness = SharedData.fitness + 5;
        money_Text.text = SharedData._money.ToString();
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
    }

    public void NextOnClick2()
    {
        m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
        m_WholePanelAnimator.Play("DataMenu_hide"); // ²¥·Å Hide ¶¯»­
        SharedData._money = SharedData._money + 500;
        SharedData._month = SharedData._month + 3;
        SharedData.pressure = SharedData.pressure + 6;
        SharedData.emotion = SharedData.emotion - 6;
        SharedData.fitness = SharedData.fitness + 6;
        money_Text.text = SharedData._money.ToString();
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
    }

    public void NextOnClick3()
    {
        m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
        m_WholePanelAnimator.Play("DataMenu_hide"); // ²¥·Å Hide ¶¯»­
        SharedData._money = SharedData._money + 800;
        SharedData._month = SharedData._month + 5;
        SharedData.pressure = SharedData.pressure + 7;
        SharedData.emotion = SharedData.emotion - 7;
        SharedData.fitness = SharedData.fitness + 7;
        money_Text.text = SharedData._money.ToString();
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
    }

    public void NextOnClick4()
    {
        m4_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥4
        m_WholePanelAnimator.Play("DataMenu_hide"); // ²¥·Å Hide ¶¯»­
        SharedData._money = SharedData._money + 1000;
        SharedData._month = SharedData._month + 6;
        SharedData.pressure = SharedData.pressure + 8;
        SharedData.emotion = SharedData.emotion - 8;
        SharedData.fitness = SharedData.fitness + 8;
        money_Text.text = SharedData._money.ToString();
        month_Text.text = SharedData._month.ToString();
        pressure_Text.text = SharedData.pressure.ToString();
        emotion_Text.text = SharedData.emotion.ToString();
        fitness_Text.text = SharedData.fitness.ToString();
    }
}
