using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    /// <summary>�X�R�A��\������ UI �̃e�L�X�g</summary>
    public GameObject m_scoreText;
    private void Update()
    {
        // �X�R�A����ʂɕ\������
        Text scoreText = m_scoreText.GetComponent<Text>();
        scoreText.text = "Score: " + ScoreManager.m_score.ToString();
    }
}