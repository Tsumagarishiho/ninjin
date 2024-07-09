using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ゲームを管理するコンポーネント
/// ライフと得点、それらの UI を制御する
/// ゲーム内に一つだけ存在させること。
/// </summary>
public class GameManagerSecondTermFifthWeek : MonoBehaviour
{
    /// <summary>スコアを表示するテキスト</summary>
    [SerializeField] Text _scoreText = default;

    public static int _score = 0;

    void Start()
    {
        AddScore(0);
    }

    /// <summary>
    /// 得点を追加し、表示を更新する。
    /// </summary>
    /// <param name="score">加算したい得点。負の値を渡すと減点する。得点表示の更新だけをしたい時は 0 を渡す。</param>
    public void AddScore(int score)
    {
        Debug.Log($"スコアの上昇量{score}");
        _score += score;
        _scoreText.text = "Score:" + _score.ToString("D4");
        Debug.Log(_score);
    }



}
