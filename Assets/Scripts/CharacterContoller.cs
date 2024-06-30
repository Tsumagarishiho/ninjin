using UnityEngine;

/// <summary>
/// �����Ă����𐧌䂷��R���|�[�l���g
/// �C�e�ɓ�����ƃG�t�F�N�g��\���i�����j���ď�����
/// </summary>
public class RockController : MonoBehaviour
{
    /// <summary>�C�e�������������ɕ\�������G�t�F�N�g</summary>
    [SerializeField] GameObject m_effectPrefab = default;

    void Update()
    {
        // ���ɗ������玩�����g��j������
        if (this.transform.position.y < -50f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shell")
        {
           // �G�t�F�N�g�ƂȂ�v���n�u���ݒ肳��Ă�����A����𐶐�����
            if (m_effectPrefab)
            {
                Instantiate(m_effectPrefab, this.transform.position, this.transform.rotation);
            }

            // �������g��j������
           // Destroy(this.gameObject);
        }
    }
}
