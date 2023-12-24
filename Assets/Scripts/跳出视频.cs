using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class 跳出视频 : MonoBehaviour
{
    public float countTime = 0f;
    public GameObject videoLayer;
    public GameObject personalPenal;
    public AudioSource audioSource;
    public Button skip_Button;
    public AudioSource buttonClick;

    public void Start()
    {
        skip_Button.onClick.AddListener(NextOnClick);
    }
    // 在 Update 函数中计时
    void Update()
    {
        CountTime();
    }

    public void NextOnClick()
    {
        buttonClick.Play();
        videoLayer.SetActive(false);
        personalPenal.SetActive(true);
        audioSource.Play();
    }

    // 计时函数
    void CountTime()
    {
        countTime += Time.deltaTime;
        if (countTime > 30.5f)
        {
            if (videoLayer != null)
            {
                videoLayer.SetActive(false);
                personalPenal.SetActive(true);
                audioSource.Play();
            }
        }
    }
}
