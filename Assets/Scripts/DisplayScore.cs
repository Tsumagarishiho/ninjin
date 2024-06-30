using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    /// <summary>スコアを表示する UI のテキスト</summary>
    public GameObject m_scoreText;
    private void Update()
    {
        // スコアを画面に表示する
        Text scoreText = m_scoreText.GetComponent<Text>();
        scoreText.text = "Score: " + ScoreManager.m_score.ToString();
    }
}