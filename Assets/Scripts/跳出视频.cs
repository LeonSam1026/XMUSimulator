using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class 跳出视频 : MonoBehaviour
{
    public float countTime = 0f;
    public GameObject videoLayer;
<<<<<<< HEAD:Assets/Scripts/跳出视频.cs
    public GameObject personalPenal;
    public AudioSource audioSource;
=======
>>>>>>> parent of 86d2015 (Update 12/23):Game Mainbody/Assets/Scripts/跳出视频.cs

    // 在 Update 函数中计时
    void Update()
    {
        CountTime();
    }

    // 计时函数
    void CountTime()
    {
        countTime += Time.deltaTime;
<<<<<<< HEAD:Assets/Scripts/跳出视频.cs
        if (countTime > 30.5f)
=======
        if (countTime > 33.55f)
>>>>>>> parent of 86d2015 (Update 12/23):Game Mainbody/Assets/Scripts/跳出视频.cs
        {
            if (videoLayer != null)
            {
                videoLayer.SetActive(false);
<<<<<<< HEAD:Assets/Scripts/跳出视频.cs
                personalPenal.SetActive(true);
                audioSource.Play();
=======
>>>>>>> parent of 86d2015 (Update 12/23):Game Mainbody/Assets/Scripts/跳出视频.cs
            }
        }
    }
}
