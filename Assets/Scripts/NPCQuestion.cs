using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class NPCQuestion : MonoBehaviour
{
    public Button next_Button;
    public GameObject m_ThisPanel;
    public GameObject m_NextPanel;
    public Animator m_ThisAnimator;
    public Animator m_NextAnimator;
    public AudioSource buttonClick;


    public void Start()
    {
        next_Button.onClick.AddListener(NextOnClick);
    }

    public void NextOnClick()
    {
        buttonClick.Play();
        m_NextPanel.SetActive(true);
        m_NextAnimator.Play("question_show");
        m_ThisPanel.SetActive(false);
        m_ThisAnimator.Play("question_hide");
    }
}
