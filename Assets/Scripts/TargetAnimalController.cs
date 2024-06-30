using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �^�[�Q�b�g�u���b�N�i�{�[�����������������u���b�N�j�𐧌䂷��
/// �^�[�Q�b�g�u���b�N�� GameObject �ɒǉ����Ďg��
/// </summary>
public class TargetAnimalController : MonoBehaviour
{
    /// <summary>�u���b�N���󂵂����̓��_</summary>
    int m_score = 50;
    /// <summary>�X�R�A�}�l�[�W���[</summary>
    GameObject m_scoreManager;

    void Start()
    {
        m_scoreManager = GameObject.Find("GameManager");    // GameManager ��T���Ď���Ă���
    }

    void Update()
    {

    }

    /// <summary>
    /// Collider �ɏՓ˔��肪���������ɌĂ΂��
    /// </summary>
    /// <param name="collision">�Փ˂̏��</param>
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // �֐����Ăяo���ꂽ�� Console �Ƀ��O���o�͂���

        // �Փˑ��肪�{�[���������瓾�_��ǉ����A�������g��j������
        if (collision.gameObject.tag == "Shell")
        {
            if (m_scoreManager != null)
            {
                ScoreManager sm = m_scoreManager.GetComponent<ScoreManager>();
                ScoreManager.AddScore(m_score);
                sm.BlockBreakCounter += 1;
            }
           // Destroy(this.gameObject);
        }
    }

    /// <summary>
    /// Collider �ɐڐG����i�g���K�[���[�h���j�����������ɌĂ΂��
    /// </summary>
    /// <param name="collision">�Փ˂̏��</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter OnTriggerEnter2D."); // �֐����Ăяo���ꂽ�� Console �Ƀ��O���o�͂���

        // �Փˑ��肪�{�[���������瓾�_��ǉ����A�������g��j������
        if (collision.gameObject.tag == "Shell")
        {
            if (m_scoreManager != null)
            {
                ScoreManager sm = m_scoreManager.GetComponent<ScoreManager>();
                ScoreManager.AddScore(m_score);
                sm.BlockBreakCounter += 1;
            }
            Destroy(this.gameObject);
        }
    }
}
