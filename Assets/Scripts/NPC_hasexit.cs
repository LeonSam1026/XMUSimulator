using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class NPC_hasexit : MonoBehaviour
{
    public Button exit_Button;
    public GameObject m_ThisPanel;
    public Animator m_ThisAnimator;
    public GameObject m_exitPanel;
    public Animator m_exitAnimator;
    public AudioSource buttonClick;

    public void Start()
    {
        exit_Button.onClick.AddListener(NextOnClick);
    }

    public void NextOnClick()
    {
        buttonClick.Play();
        m_exitPanel.SetActive(true);
        m_ThisPanel.SetActive(false);
        
        m_exitAnimator.Play("StartMenu_Show");
        m_ThisAnimator.Play("question_hide");
    }
}
