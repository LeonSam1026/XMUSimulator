using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class CompetitionQuestion : MonoBehaviour
{
    public Button m1_Button;
    public Button m2_Button;
    public Button m3_Button;
    public TextMeshProUGUI q_Text;
    public TextMeshProUGUI a1_Text;
    public TextMeshProUGUI a2_Text;
    public TextMeshProUGUI a3_Text;
    public TextMeshProUGUI result_Text;
    public GameObject m_WholePanel;
    public GameObject m_Letter;
    public Animator m_NextPanelAnimator;
    public int flag = 0;
    public int num = 0;

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
            q_Text.text = "5x - 4 = 2(2x - 3) \n x = ?";
            a1_Text.text = "x = 10";
            a2_Text.text = "x = 12";
            a3_Text.text = "x = 16";
            flag++;
        }
        else if (flag == 1)
        {
            q_Text.text = "9 - (-11) + (-21) = ? ";
            a1_Text.text = "1";
            a2_Text.text = "0";
            a3_Text.text = "-1";
            flag++;
            num++;
        }
        else if (flag == 2)
        {
            q_Text.text = "(-20) + (-12) - (-5) - 7 = ? ";
            a1_Text.text = "-34";
            a2_Text.text = "-30";
            a3_Text.text = "-24";
            flag++;
        }
        else if (flag == 3)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            num++;
            flag++;
            if (num >= 4)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("First Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if(num ==3)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Second Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 2)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Third Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 1)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Participation Award");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 0)
            {
                q_Text.text = String.Format("Unfortunately, you did not win the award. Keep working hard next time!");
            }
        }
        else if (flag == 4)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void NextOnClick2()
    {
        if (flag == 0)
        {
            q_Text.text = "5x - 4 = 2(2x - 3) \n x = ?";
            a1_Text.text = "x = 10";
            a2_Text.text = "x = 12";
            a3_Text.text = "x = 16";
            flag++;
            num++;
        }
        else if (flag == 1)
        {
            q_Text.text = "9 - (-11) + (-21) = ? ";
            a1_Text.text = "1";
            a2_Text.text = "0";
            a3_Text.text = "-1";
            flag++;
        }
        else if (flag == 2)
        {
            q_Text.text = "(-20) + (-12) - (-5) - 7 = ? ";
            a1_Text.text = "-34";
            a2_Text.text = "-30";
            a3_Text.text = "-24";
            flag++;
        }
        else if (flag == 3)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            flag++;
            if (num >= 4)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("First Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 3)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Second Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 2)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Third Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 1)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Participation Award");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 0)
            {
                q_Text.text = String.Format("Unfortunately, you did not win the award. Keep working hard next time!");
            }
        }
        else if (flag == 4)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
        }
    }

    public void NextOnClick3()
    {
        if (flag == 0)
        {
            q_Text.text = "5x - 4 = 2(2x - 3) \n x = ?";
            a1_Text.text = "x = 10";
            a2_Text.text = "x = 12";
            a3_Text.text = "x = 16";
            flag++;
        }
        else if (flag == 1)
        {
            q_Text.text = "9 - (-11) + (-21) = ? ";
            a1_Text.text = "1";
            a2_Text.text = "0";
            a3_Text.text = "-1";
            flag++;
        }
        else if (flag == 2)
        {
            q_Text.text = "(-20) + (-12) - (-5) - 7 = ? ";
            a1_Text.text = "-34";
            a2_Text.text = "-30";
            a3_Text.text = "-24";
            flag++;
            num++;
        }
        else if (flag == 3)
        {
            m2_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥2
            m3_Button.gameObject.SetActive(false); // Òþ²Ø°´Å¥3
            a1_Text.text = "Exit";
            flag++;
            if (num >= 4)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("First Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 3)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Second Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 2)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Third Prize");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 1)
            {
                m_Letter.SetActive(true);
                result_Text.text = ("Participation Award");
                m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
            }
            else if (num == 0)
            {
                q_Text.text = String.Format("Unfortunately, you did not win the award. Keep working hard next time!");
            }
        }
        else if (flag == 4)
        {
            m_WholePanel.SetActive(false);
            m_WholePanel.GetComponent<CanvasGroup>().interactable = false;
        }
    }
}
