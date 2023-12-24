using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Association : MonoBehaviour
{
    public Button m_Button;
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
            m_ThisPanel.SetActive(false);
            m_ThisPanel.GetComponent<CanvasGroup>().interactable = false;
            m_NextPanel.SetActive(true);
            m_NextPanelAnimator.Play("DataMenu_show"); // ²¥·Å Show ¶¯»­
    }
}
