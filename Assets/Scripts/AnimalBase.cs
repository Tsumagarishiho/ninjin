using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    /// <summary>�A�C�e������������ɖ���ʉ�</summary>
    [Tooltip("�A�C�e������������ɖ炷���ʉ�")]
    [SerializeField] AudioClip _sound = default;
    /// <summary>�A�C�e���̌��ʂ����������邩</summary>
    [Tooltip("Get ��I�ԂƁA��������Ɍ��ʂ���������BUse ��I�ԂƁA�A�C�e�����g�������ɔ�������")]
    [SerializeField] ActivateTiming _whenActivated = ActivateTiming.Get;
    /// <summary>�X�R�A�}�l�[�W���[</summary>
    GameObject m_scoreManager;

    void Start()
    {
        m_scoreManager = GameObject.Find("GameManager");    // GameManager ��T���Ď���Ă���
    }

    void Update()
    {

    }
    public abstract void Activate();
    /// <summary>
    /// Collider �ɏՓ˔��肪���������ɌĂ΂��
    /// </summary>
    /// <param name="collision">�Փ˂̏��</param>
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // �֐����Ăяo���ꂽ�� Console �Ƀ��O���o�͂���

        // �Փˑ��肪�{�[���������瓾�_��ǉ����A�������g��j������
        if (collision.gameObject.tag == "Shell")
        {
            if (m_scoreManager != null)
            {
                ScoreManager sm = m_scoreManager.GetComponent<ScoreManager>();
                //ScoreManager.AddScore(m_score);
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
                //ScoreManager.AddScore(m_score);
                sm.BlockBreakCounter += 1;
            }
            Destroy(this.gameObject);
        }
    }*/


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Shell"))
        {
            Debug.Log("Shell����");
            if (_sound)
            {
                AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
            }

            // �A�C�e�������^�C�~���O�ɂ���ď����𕪂���
            if (_whenActivated == ActivateTiming.Get)
            {
                Debug.Log("Activate����");
                Activate();
                Destroy(this.gameObject,10f);
            }
            else if (_whenActivated == ActivateTiming.Use)
            {
                // �����Ȃ����Ɉړ�����
                this.transform.position = Camera.main.transform.position;
                // �R���C�_�[�𖳌��ɂ���
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }

    /// <summary>
    /// �A�C�e�������A�N�e�B�x�[�g���邩
    /// </summary>
    enum ActivateTiming
    {
        /// <summary>��������ɂ����g��</summary>
        Get,
        /// <summary>�u�g���v�R�}���h�Ŏg��</summary>
        Use,
    }
}
