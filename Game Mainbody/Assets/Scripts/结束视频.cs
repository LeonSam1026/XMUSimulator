using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static SharedData;

public class 结束视频 : MonoBehaviour
{
    public float countTime = 0f;
    public GameObject videoLayer;

    void Update()
    {
        if (SharedData._month >= 20)
        {
            videoLayer.SetActive(true);
            CountTime();
            // 在 Update 函数中计时
        }
    }

    // 计时函数
    void CountTime()
    {
        countTime += Time.deltaTime;
        if (countTime > 17.55f)
        {
            if (videoLayer != null)
            {
                videoLayer.SetActive(false);
            }
        }
    }
}

