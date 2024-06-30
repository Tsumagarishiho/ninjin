using UnityEngine;

/// <summary>
/// �C�� (Canon) �𐧌䂷��R���|�[�l���g
/// </summary>
public class CanonController : MonoBehaviour
{
    /// <summary>�C�e�Ƃ��Đ�������v���n�u</summary>
    [SerializeField] GameObject m_shellPrefab = default;
    /// <summary>�C�����w�肷��</summary>
    [SerializeField] Transform m_muzzle = default;
    [SerializeField] Transform m_crosshair;
    AudioSource m_audio = default;

    [SerializeField] GameObject m_prefab = default;
    [SerializeField] float m_interval = 1f;
    float m_timer;

    void Start()
    {
        m_audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        //transform.up = Vector2.right;
        transform.up = m_crosshair.position - transform.position;


        // Time.deltaTime �́u�O�t���[������̌o�ߎ��ԁv���擾����
        // �����ώZ���āu�o�ߎ��ԁv�����߂�̂� Unity �ł̓T�^�I�ȃv���O���~���O�̃p�^�[���ł���
        m_timer += Time.deltaTime;

        // �u�o�ߎ��ԁv���u��������Ԋu�v�𒴂�����
        if (m_timer > m_interval)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                m_timer = 0;    // �^�C�}�[�����Z�b�g���Ă���
                m_audio.Play();
                Instantiate(m_shellPrefab, m_muzzle.position, this.transform.rotation);
            }
        }
    }
}
