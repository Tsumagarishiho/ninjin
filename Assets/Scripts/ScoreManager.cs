using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI (Text) �𑀍삷�邽�߂ɒǉ����Ă���

public class ScoreManager : MonoBehaviour
{
   public static int m_score;
    public int BlockBreakCounter;


    /// <summary>
    /// �X�R�A�����Z����Bpublic �Ƃ��Ċ֐�����邱�Ƃɂ��A�O������Ăяo����悤�ɂȂ�B
    /// </summary>
    public static void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score �̒Z�k�`
        Debug.LogFormat("Score: {0}", m_score);
    }

    /// <summary>
    /// private�ipublic �Ƃ��Ă��Ȃ��j�֐��́A�O������͌Ăяo���Ȃ��B
    /// </summary>
    void Dummy()
    {
    }
}
