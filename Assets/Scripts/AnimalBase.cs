using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class AnimalBase : MonoBehaviour
{
    /// <summary>アイテムを取った時に鳴る効果音</summary>
    [Tooltip("アイテムを取った時に鳴らす効果音")]
    [SerializeField] AudioClip _sound = default;
    /// <summary>アイテムの効果をいつ発揮するか</summary>
    [Tooltip("Get を選ぶと、取った時に効果が発動する。Use を選ぶと、アイテムを使った時に発動する")]
    [SerializeField] ActivateTiming _whenActivated = ActivateTiming.Get;
    /// <summary>スコアマネージャー</summary>
    GameObject m_scoreManager;

    void Start()
    {
        m_scoreManager = GameObject.Find("GameManager");    // GameManager を探して取ってくる
    }

    void Update()
    {

    }
    public abstract void Activate();
    /// <summary>
    /// Collider に衝突判定があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    /*void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter OnCollisionEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手がボールだったら得点を追加し、自分自身を破棄する
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
    /// Collider に接触判定（トリガーモード時）があった時に呼ばれる
    /// </summary>
    /// <param name="collision">衝突の情報</param>
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter OnTriggerEnter2D."); // 関数が呼び出されたら Console にログを出力する

        // 衝突相手がボールだったら得点を追加し、自分自身を破棄する
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
            Debug.Log("Shell反応");
            if (_sound)
            {
                AudioSource.PlayClipAtPoint(_sound, Camera.main.transform.position);
            }

            // アイテム発動タイミングによって処理を分ける
            if (_whenActivated == ActivateTiming.Get)
            {
                Debug.Log("Activate反応");
                Activate();
                Destroy(this.gameObject,10f);
            }
            else if (_whenActivated == ActivateTiming.Use)
            {
                // 見えない所に移動する
                this.transform.position = Camera.main.transform.position;
                // コライダーを無効にする
                GetComponent<Collider2D>().enabled = false;
            }
        }
    }

    /// <summary>
    /// アイテムをいつアクティベートするか
    /// </summary>
    enum ActivateTiming
    {
        /// <summary>取った時にすぐ使う</summary>
        Get,
        /// <summary>「使う」コマンドで使う</summary>
        Use,
    }
}
