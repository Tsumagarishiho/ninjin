using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCatController : AnimalBase
{
    /// <summary>�u���b�N���󂵂����̓��_</summary>
    int m_score = 150;

    private void Start()
    {
        m_score = 150;
    }
    public override void Activate()
    {
        FindObjectOfType<GameManagerSecondTermFifthWeek>().AddScore(m_score);
    }
}
