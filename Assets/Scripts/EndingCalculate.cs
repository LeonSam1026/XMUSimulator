using UnityEngine;
using UnityEngine.UI;
using static SharedData;

public class TextSwitcher : MonoBehaviour
{
    public Text myText1; // 显示不同结果文本的Text组件
    public Text myText2; // 显示不同结果文本的Text组件
    public Text myText3; // 显示不同结果文本的Text组件

    public string[] texts = new string[9]; // 存放所有不同结果的文字内容的数组  

    public int score;
    public int emotion;
    public int fitness;

    void Start()
    {
        texts = new string[] {
            "恭喜你触发保研结局，成功推免！",
            "恭喜你获得三好学生，接下来继续努力！",
            "恭喜你触发普通人结局，人生是旷野不是轨道！",
            "恭喜你触发情绪稳定的大学生结局！你就是卡皮巴拉本拉吧！",
            "恭喜你有所成长，学会控制自己的情绪！",
            "众生皆苦，学会开心一点哦！",
            "自律的人生有多可怕，健康达人就是你！",
            "保持健康与洁净，整个人心情都变好啦！",
            "要多多锻炼哦，身体是革命的本钱！"
        };

        score = GetScore();
        emotion = GetEmotion();
        fitness = GetFitness();

        if (score >= 110)
        {
            myText1.text = texts[0];
        }
        else if (score >= 100)
        {
            myText1.text = texts[1];
        }
        else
        {
            myText1.text = texts[2];
        }

        if (emotion >= 110)
        {
            myText2.text = texts[3];
        }
        else if (emotion >= 100)
        {
            myText2.text = texts[4];
        }
        else
        {
            myText2.text = texts[5];
        }

        if (fitness >= 110)
        {
            myText3.text = texts[6];
        }
        else if (fitness >= 100)
        {
            myText3.text = texts[7];
        }
        else
        {
            myText3.text = texts[8];
        }
    }

    private int GetScore() { return SharedData.score; }
    private int GetEmotion() { return SharedData.emotion; }
    private int GetFitness() { return SharedData.fitness; }
}
