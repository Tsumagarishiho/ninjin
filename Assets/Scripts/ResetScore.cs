using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    public void Start()
    {
        ScoreManager.m_score = 0;
    }
}
