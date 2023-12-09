using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public Button m_Button;
    public TextMeshProUGUI m_Text;
    public int flag = 0;
    public GameObject m_ThisPanel;
    public GameObject m_NextPanel;
    public Animator m_NextPanelAnimator;

    public void Start()
    {
        m_Button.onClick.AddListener(NextOnClick);
        m_NextPanelAnimator = m_NextPanel.GetComponent<Animator>();
    }

    public void NextOnClick()
    {
        if (flag == 0)
        {
            m_Text.text = "Please choose the most appropriate one based on your understanding! ";
            flag = 1;
        }
        else if(flag == 1)
        {
            m_ThisPanel.SetActive(false);
            m_ThisPanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­

        }
    }
}
