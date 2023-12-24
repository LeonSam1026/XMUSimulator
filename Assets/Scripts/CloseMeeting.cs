using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;


public class CloseMeeting : MonoBehaviour
{
    public Button next_Button;
    public GameObject m_WholePanel;

    public void Start()
    {
        next_Button.onClick.AddListener(NextOnClick);
    }

    public void NextOnClick()
    {
        m_WholePanel.gameObject.SetActive(false);
    }
}
