using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public static float CountDownTime;  // �J�E���g�_�E���^�C��
    public Text TextCountDown;              // �\���p�e�L�X�gUI

    // Use this for initialization
    void Start()
    {
        CountDownTime = 30.0F;  // �J�E���g�_�E���J�n�b�����Z�b�g
    }

    // Update is called once per frame
    void Update()
    {
        // �J�E���g�_�E���^�C���𐮌`���ĕ\��
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        // �o�ߎ����������Ă���
        CountDownTime -= Time.deltaTime;
        // 0.0�b�ȉ��ɂȂ�����J�E���g�_�E���^�C����0.0�ŌŒ�i�~�܂����悤�Ɍ�����j
        if (CountDownTime <= 0.0F)
        {
            CountDownTime = 0.0F;
        }

        if (CountDownTime <= 0)
        {//countdown��0�ȉ��̎��Ɏ��s
            SceneManager.LoadScene("Result");//�V�[���ړ�
        }
    }
}