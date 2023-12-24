using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class Question : MonoBehaviour
{
    public Button m1_Button;
    public Button m2_Button;
    public Button m3_Button;
    public TextMeshProUGUI q_Text;
    public TextMeshProUGUI a1_Text;
    public TextMeshProUGUI a2_Text;
    public TextMeshProUGUI a3_Text;
    public GameObject m_ThisPanel;
    public GameObject m_WholePanel;
    public AudioSource newSource;
    public AudioSource oldSource;
    public int flag = 0;
    public int score = 0;

    public void Start()
    {
        m1_Button.onClick.AddListener(NextOnClick1);
        m2_Button.onClick.AddListener(NextOnClick2);
        m3_Button.onClick.AddListener(NextOnClick3);
    }

    public void NextOnClick1()
    {
        if (flag == 0)
        {
            q_Text.text = "What would you do if you failed the election this time? ";
            a1_Text.text = "Be angry!";
            a2_Text.text = "Never give up!";
            a3_Text.text = "Keep tring!";
            flag ++;
            score = score + 6;
        }
        else if (flag == 1)
        {
            q_Text.text = "How would you balance learning and work? ";
            a1_Text.text = "Can't balance";
            a2_Text.text = "Work priority";
            a3_Text.text = "Increase efficiency"; 
            flag ++;
            score = score + 6;
        }
        else if (flag == 2)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            q_Text.text = "Your score is: %d/30!";
            score = score + 6;
            flag++;
            if (score >= 20)
            {
                q_Text.text = String.Format("Your score is: {0}/30!\nCongratulations! You win!", score);
            }
            else
            {
                q_Text.text = String.Format("Your score is: {0}/30!\n\n\nPity! You lose! Keep trying!", score);
            }
        }
        else if (flag == 3)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            newSource.Play();
            oldSource.Stop();
        }
    }

    public void NextOnClick2()
    {
        if (flag == 0)
        {
            q_Text.text = "What would you do if you failed the election this time? ";
            a1_Text.text = "Be angry!";
            a2_Text.text = "Never give up!";
            a3_Text.text = "Keep tring!";
            flag++;
            score = score + 8;
        }
        else if (flag == 1)
        {
            q_Text.text = "How would you balance learning and work? ";
            a1_Text.text = "Can't balance";
            a2_Text.text = "Work priority";
            a3_Text.text = "Increase efficiency";
            flag++;
            score = score + 8;
        }
        else if (flag == 2)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            q_Text.text = "Your score is: %d/30!";
            score = score + 8;
            flag++;
            if (score >= 20)
            {
                q_Text.text = String.Format("Your score is: {0}/30!\nCongratulations! You win!", score);
            }
            else
            {
                q_Text.text = String.Format("Your score is: {0}/30!\n\n\nPity! You lose! Keep trying!", score);
            }
        }
        else if (flag == 3)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            newSource.Play();
            oldSource.Stop();

        }
    }

    public void NextOnClick3()
    {
        if (flag == 0)
        {
            q_Text.text = "What would you do if you failed the election this time? ";
            a1_Text.text = "Be angry!";
            a2_Text.text = "Never give up!";
            a3_Text.text = "Keep tring!";
            flag++;
            score = score + 10;
        }
        else if (flag == 1)
        {
            q_Text.text = "How would you balance learning and work? ";
            a1_Text.text = "Can't balance";
            a2_Text.text = "Work priority";
            a3_Text.text = "Increase efficiency";
            flag++;
            score = score + 10;
        }
        else if (flag == 2)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            q_Text.text = "Your score is: %d/30!";
            score = score + 10;
            flag++;
            if (score >= 20)
            {
                q_Text.text = String.Format("Your score is: {0}/30!\nCongratulations! You win!", score);
            }
            else
            {
                q_Text.text = String.Format("Your score is: {0}/30!\n\n\nPity! You lose! Keep trying!", score);
            }
        }
        else if (flag == 3)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
            newSource.Play();
            oldSource.Stop();

        }
    }
}
