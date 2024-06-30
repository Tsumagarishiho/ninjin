using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   // UI (Text) を操作するために追加している

public class ScoreManager : MonoBehaviour
{
   public static int m_score;
    public int BlockBreakCounter;


    /// <summary>
    /// スコアを加算する。public として関数を作ることにより、外部から呼び出せるようになる。
    /// </summary>
    public static void AddScore(int score)
    {
        m_score += score;   // m_score = m_score + score の短縮形
        Debug.LogFormat("Score: {0}", m_score);
    }

    /// <summary>
    /// private（public とつけていない）関数は、外部からは呼び出せない。
    /// </summary>
    void Dummy()
    {
    }
}
