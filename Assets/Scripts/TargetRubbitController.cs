using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// ターゲットブロック（ボールが当たったら壊れるブロック）を制御する
/// ターゲットブロックの GameObject に追加して使う
/// </summary>
public class TargetRubbitController : AnimalBase
{
    /// <summary>ブロックを壊した時の得点</summary>
   int m_score = 300;

    private void Start()
    {
        m_score = 300;
    }

    public override void Activate()
    {
        Debug.Log("スコア加算反応");
        FindObjectOfType<GameManagerSecondTermFifthWeek>().AddScore(m_score);
    }




}
