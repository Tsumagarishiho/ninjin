using UnityEngine;

/// <summary>
/// �Ə� (Crosshair) �𐧌䂷��R���|�[�l���g
/// �}�E�X�J�[�\���̈ʒu�ɏƏ����ړ�����
/// </summary>
public class CrosshairController : MonoBehaviour
{
    void Start()
    {
        // �}�E�X�J�[�\��������
        Cursor.visible = true;
    }

    void Update()
    {
        // Camera.main �Ń��C���J�����iMainCamera �^�O�̕t���� Camera�j���擾����
        // Camera.ScreenToWorldPoint �֐��ŁA�X�N���[�����W�����[���h���W�ɕϊ�����
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;    // Z ���W���J�����Ɠ����ɂȂ��Ă���̂ŁA���Z�b�g����
        this.transform.position = mousePosition;
    }
}