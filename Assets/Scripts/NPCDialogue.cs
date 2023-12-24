using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class NPCDialogue : MonoBehaviour
{
    public Button A1_Button;
    public Button A2_Button;
    public Button A3_Button;
    public GameObject m_ThisPanel;
    public GameObject m_Next1Panel;
    public GameObject m_Next2Panel;
    public GameObject m_Next3Panel;
    public Animator m_Next1Animator;
    public Animator m_Next2Animator;
    public Animator m_Next3Animator;
    public Animator m_ThisAnimator;
    public AudioSource buttonClick;

    public void Start()
    {
        A1_Button.onClick.AddListener(NextOnClick1);
        A2_Button.onClick.AddListener(NextOnClick2);
        A3_Button.onClick.AddListener(NextOnClick3);
    }

    public void NextOnClick1()
    {
        buttonClick.Play();
        m_Next1Panel.SetActive(true);
        m_ThisPanel.SetActive(false);
        m_Next1Animator.Play("question_show");
        m_ThisAnimator.Play("question_hide");
    }

    public void NextOnClick2()
    {
        buttonClick.Play();
        m_Next2Panel.SetActive(true);
        m_ThisPanel.SetActive(false);

        m_Next2Animator.Play("question_show");
        m_ThisAnimator.Play("question_hide");
    }

    public void NextOnClick3()
    {
        buttonClick.Play();
        m_Next3Panel.SetActive(true);
        m_ThisPanel.SetActive(false);

        m_Next3Animator.Play("question_show");
        m_ThisAnimator.Play("question_hide");
    }
}
