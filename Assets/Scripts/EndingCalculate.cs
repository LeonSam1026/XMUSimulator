using UnityEngine;
using UnityEngine.UI;
using static SharedData;

public class TextSwitcher : MonoBehaviour
{
    public Text myText1; // ��ʾ��ͬ����ı���Text���
    public Text myText2; // ��ʾ��ͬ����ı���Text���
    public Text myText3; // ��ʾ��ͬ����ı���Text���

    public string[] texts = new string[9]; // ������в�ͬ������������ݵ�����  

    public int score;
    public int emotion;
    public int fitness;

    void Start()
    {
        texts = new string[] {
            "��ϲ�㴥�����н�֣��ɹ����⣡",
            "��ϲ��������ѧ��������������Ŭ����",
            "��ϲ�㴥����ͨ�˽�֣������ǿ�Ұ���ǹ����",
            "��ϲ�㴥�������ȶ��Ĵ�ѧ����֣�����ǿ�Ƥ���������ɣ�",
            "��ϲ�������ɳ���ѧ������Լ���������",
            "�����Կ࣬ѧ�Ὺ��һ��Ŷ��",
            "���ɵ������ж���£��������˾����㣡",
            "���ֽ�����ྻ�����������鶼�������",
            "Ҫ������Ŷ�������Ǹ����ı�Ǯ��"
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
