using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDogController : AnimalBase
{
    /// <summary>�u���b�N���󂵂����̓��_</summary>
    int m_score = 100;

    private void Start()
    {
        m_score = 100;
    }

    public override void Activate()
    {
        FindObjectOfType<GameManagerSecondTermFifthWeek>().AddScore(m_score);
    }
}
