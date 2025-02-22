using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public static float CountDownTime;  // カウントダウンタイム
    public Text TextCountDown;              // 表示用テキストUI

    // Use this for initialization
    void Start()
    {
        CountDownTime = 30.0F;  // カウントダウン開始秒数をセット
    }

    // Update is called once per frame
    void Update()
    {
        // カウントダウンタイムを整形して表示
        TextCountDown.text = String.Format("Time: {0:00.00}", CountDownTime);
        // 経過時刻を引いていく
        CountDownTime -= Time.deltaTime;
        // 0.0秒以下になったらカウントダウンタイムを0.0で固定（止まったように見せる）
        if (CountDownTime <= 0.0F)
        {
            CountDownTime = 0.0F;
        }

        if (CountDownTime <= 0)
        {//countdownが0以下の時に実行
            SceneManager.LoadScene("Result");//シーン移動
        }
    }
}