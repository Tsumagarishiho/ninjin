using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �^�[�Q�b�g�u���b�N�i�{�[�����������������u���b�N�j�𐧌䂷��
/// �^�[�Q�b�g�u���b�N�� GameObject �ɒǉ����Ďg��
/// </summary>
public class TargetRubbitController : AnimalBase
{
    /// <summary>�u���b�N���󂵂����̓��_</summary>
   int m_score = 300;

    private void Start()
    {
        m_score = 300;
    }

    public override void Activate()
    {
        Debug.Log("�X�R�A���Z����");
        FindObjectOfType<GameManagerSecondTermFifthWeek>().AddScore(m_score);
    }




}
