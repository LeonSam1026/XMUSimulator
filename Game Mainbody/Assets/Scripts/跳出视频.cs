using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class 跳出视频 : MonoBehaviour
{
    public float countTime = 0f;
    public GameObject videoLayer;

    // 在 Update 函数中计时
    void Update()
    {
        CountTime();
    }

    // 计时函数
    void CountTime()
    {
        countTime += Time.deltaTime;
        if (countTime > 33.55f)
        {
            if (videoLayer != null)
            {
                videoLayer.SetActive(false);
            }
        }
    }
}
