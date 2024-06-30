using UnityEngine;

/// <summary>
/// �C�e (Shell) �𐧌䂷��R���|�[�l���g
/// </summary>
public class ShellController : MonoBehaviour
{
    /// <summary>���˂��鑬�x</summary>
    [SerializeField] float m_initialSpeed = 5f;

    [SerializeField] GameObject m_effectPrefab;

    void Start()
    {
        // Rigidbody ���擾���Ĕ��˂���
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.velocity = this.transform.up * m_initialSpeed;
    }

    void Update()
    {
        // ���ɗ������玩�����g��j������
        if (this.transform.position.y < -10f)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var tag = collision.gameObject.tag;

        if (tag == "Animal" || tag == "Ground" || tag == "Shell")
        {
            // �G�t�F�N�g�ƂȂ�v���n�u���ݒ肳��Ă�����A����𐶐�����
            if (m_effectPrefab)
            {
                Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
            }



            // �������g��j������
            Destroy(this.gameObject);
        }
    }
}
